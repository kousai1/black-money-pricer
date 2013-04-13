function [k,mu_e,sigma_x,sigma_e,p_xe,lambda_e,lambda_x] = parametersExtraction(c,G,W,d,F,dt,maturity)
%% Function: PARAMETERS EXTRACTION
% Retourne les paramètres du processus stochastiques du modèle risk-neutre

%% First elements -- Cf Transition equation and Covariance matrix for derivation
% Mu_e
mu_e = c(2,1)/dt;

% k
k = -(1/(sum(maturity)+dt))*(sum(log(abs(F(:,1))))+log(abs(G(1,1))));

% Sigma_x
temp = (abs(W(1,1))*2*k)/(1-exp(-2*k*dt));
sigma_x = sqrt(temp);

% Sigma_e
sigma_e = sqrt(abs(W(2,2))/dt);

% P_xe
p_xe = (W(1,2)+W(2,1))*(k/((1-exp(-k*dt))*sigma_x*sigma_e*2));

%% Risk premiums : Lambda_e & Lambda_x
d_temp = zeros(length(maturity),1);
X = zeros(length(maturity),2); % 2 est relatif au nombre de param à déterminer

for i = 1 : length(maturity)
    temp1 = (1-exp(-2*k*maturity(i)))*(sigma_x^2/(2*k));
    temp2 = (sigma_e^2*maturity(i));
    temp3 = 2*(1-exp(-k*maturity(i)))*((p_xe * sigma_x * sigma_e)/k);
    cste = mu_e*maturity(i) + (1/2)*(temp1+temp2+temp3);
    
    d_temp(i) = d(i) - cste;
    
    X(i,1) = -maturity(i);
    X(i,2) = -(1-exp(-k*maturity(i)))/k;
end

% Solution (Least Squares approach)
invXX = (X'*X)\eye(size(X,2));
b = invXX*X'*d_temp;

% Risk premiums into b
lambda_e = b(1);
lambda_x = b(2);

end