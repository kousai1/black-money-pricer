function [M,C,R,likelihood] = kalman_filter (y,x0,C0,cc,G,W,d,F,V)

NumObservations = size(y,2); % Largeur du vecteur d'observations (nbre cols)
M = zeros(2,NumObservations); % Matrice des espérances de la variable d'état
% C_t Matrice de covariance de x_t à l'instant t sachant t (à la correction)
% R_t Matrice de covariance de x_t à l'instant t sachant les infos t-1
% (à la prédiction)

NbContracts = size(y,1); % Nombre de lignes de y = nbre de contrats

% valeurs initiales
M_t = x0 ; 
C_t = C0 ;

a_t = zeros(2,NumObservations);
R_t = zeros(2,2,NumObservations);

C = zeros(2,2,NumObservations);
v = zeros(NbContracts,NumObservations); % le vecteur des erreurs de prévisions
% y = matrice des observations, de taille NbContrats * NumObservations
likelihood = zeros(NumObservations,1);

for i = 1 : NumObservations
    
    % Prédiction : a_t ou Espérance de x_t sachant les infos jusque t-1
    % et R_t
    
    a_t(:,i) = G*M_t + cc;
    R_t(:,:,i) = G*C_t*G' + W;
    
    % Mesure de l'erreur de prévision en utilisant la nouvelle information
    
    v(:,i) = y(:,i) - (F*a_t(:,i) + d);
    
    % Calcul du gain

    Q = F*R_t(:,:,i)*F'+V; % Covariance de l'erreur sachant les infos jusqu'à t-1
    invQ = Q\eye(size(Q,1)); 
    
    K = R_t(:,:,i)*F'*invQ;
    
    % Correction
    
    M(:,i) = a_t(:,i) + K*v(:,i);
    C(:,:,i) = R_t(:,:,i)-K*F*R_t(:,:,i);
    
    M_t = M(:,i);
    C_t = C(:,:,i);
    
    % Log-Likehood
    dQ=det(Q);
    if(dQ<=0)
        
       dQ = 10^(-10); % Donnant donc un log(dQ) infiniment négatif !
    
    end
    likelihood(i) = -0.5*log(dQ) -0.5*v(:,i)'*invQ*v(:,i);
    
end;

R = R_t;

end
