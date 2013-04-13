function [C_s,M_s,X] = kalman_smoother(R,C,G,M,c)

%KALMAN_SMOOTHER - Returning smoothed statistics of the state variable
%   C'est la fonction de calcul de l'espérance de la variable d'état x(t)
%   ainsi que de sa covariance/autocovariance "sachant toutes les données",
%   donc en partant de la fin (dernière observation).

% Allocations

NumObs= size(M,2);
M_s = zeros(2,NumObs);
C_s = zeros(2,2,NumObs);
X = zeros(2,2,NumObs-1);
J = zeros(2,2,NumObs-1); % Utile dans les formules ci-dessous
% C'est le gain J_t qui permet d'améliorer les estimations (- de bruits)

% Valeurs initiales
M_s(:,NumObs) = M(:,NumObs);
C_s(:,:,NumObs) = C(:,:,NumObs);

for i = NumObs-1 : -1 : 1

    % J_t
    invRi_1= R(:,:,i+1)\eye(size(R(:,:,i+1),1)); 
    J(:,:,i) = C(:,:,i)*G'*invRi_1;
    
    % Smoothed espérance
    M_s(:,i) = M(:,i) + J(:,:,i)*(M_s(:,i+1) - (c + G*M(:,i)));
    
    % Smoothed Covariance
    C_s(:,:,i) = C(:,:,i) + J(:,:,i)*(C_s(:,:,i+1) - R(:,:,i+1))*J(:,:,i)';
    
    % AutoCovariance between i and i+1;
    X(:,:,i) = C_s(:,:,i+1)*J(:,:,i)';
    
end