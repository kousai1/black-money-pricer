function [c,G,W,d,F,V] = buildMatrices(k,mue,sigmax,sigmae,pxe,lambdae,lambdax,VarError,dt,maturity)
% Kalman Filter matrices builder

F = zeros(length(maturity),2);
d = zeros(length(maturity),1);

% Pour l'équation de transition
c = [0;mue*dt];

G = [exp(-k*dt) 0;0 1]; % 0

w11 = (1 - exp(-2*k*dt))*(sigmax^2/(2*k)); % var(x)
w12 = (1-exp(-k*dt))*pxe*sigmax*sigmae/k; % cov(x,e) % 0
w21 = w12; % cov(x,e) % 0
w22 = (sigmae)^2*dt; % var(e) % 0

W = [w11 w12; w21 w22];

% Pour l'équation de mesure
for i = 1 : length(maturity)
    
    F(i,1) = exp(-k*maturity(i));
    F(i,2) = 1; % 0
    
    % Détermination de d (utilisation de la formule (9))
    d1 = (mue-lambdae)*maturity(i);
    d2 = (1-exp(-k*maturity(i)))*lambdax/k;
    d3 = (1-exp(-2*k*maturity(i)))*((sigmax)^2/(2*k));
    d4 = (sigmae)^2*maturity(i);
    d5 = 2*(1-exp(-k*maturity(i)))*(pxe*sigmax*sigmae)/k;
    
    % A REECRIRE
    % Corriger l'inversion
    
    d(i) = d1-d2+.5*(d3+d4+d5);
end;

V = diag(VarError);

end