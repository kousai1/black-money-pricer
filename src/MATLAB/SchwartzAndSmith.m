function [M_ts,k,mu_e,sigma_x,sigma_e,p_xe,lambda_e,lambda_x,x0out,e0out,currentLogLikelihood,nbIteration] = SchwartzAndSmith(maxiter,x0,e0,maturity,y,k,mu_e,sigma_x,sigma_e,p_xe,lambda_e,lambda_x)

%% Script: MAIN - fonction principale du programme
%   Permet la vue globable sur tout le processing

dt = 7/360; % (ou 1/52, bref des données hebdomadaires)
%maturity = [1/12, 5/12, 9/12, 13/12, 17/12]; % 5 contrats (1 mois, 5 mois...)

%TODO : LOAD FROM THE APP

VarError = ones(size(maturity))*0.005 % Donné dans le paper, c'est la

% Initialization

%[k,mu_e,sigma_x,sigma_e,p_xe,lambda_e,lambda_x,VarError] = parametersInit();

% Construction des matrices : c, G, W, d, F, V
[c,G,W,d,F,V] = buildMatrices(k,mu_e,sigma_x,sigma_e,p_xe,lambda_e,lambda_x,VarError,dt,maturity);

% Data set Simulation et dim(y) = size(maturity) * nbObserv
%yy = simuY(W,V,G,F,c,d,T,loading);

% Initial Espérance/Covariance variable d'état x_0/Cov C_0
% x0 = [0;0]; % Initial state for testing
C0=[0.1,0.1;0.1,0.1]; % Covariance Matrix C(t) = Cov[X_t,E_t]
%x0=[0.119;2.857]; % State Vector : X(t)=E[X_t;E_t] from the Paper
x0 = [x0,e0]';

% Variables de l'algorithme EM
oldLogLikelihood = 1;
nbIteration = 0;
diff = 20;
threshold = 10^-2;

%% Processing
while diff > threshold
    nbIteration = nbIteration + 1;
    % Threshold = définir un seuil et boucler
    % Tant que l'écart entre la likelihood observée et celle précédente est
    % grd
    
    % Détermination du process caché (state variable) = filtrage
    [M,C,R,likelihood] = kalman_filter(y,x0,C0,c,G,W,d,F,V);
   
    % Calcul du Log de la fonction de vraisemblance d'observer Y sachant X_t
    % (la valeur de la state prédite à chaque instant t) et le set de
    % paramètres de theta.
    currentLogLikelihood=sum(likelihood);
    
    % Displaying
    txt = sprintf('This is the iteration n°%d\n the loglikehood equals %f\n',...
        nbIteration,currentLogLikelihood);
    %disp(txt);
    
    % Différence
    diff = currentLogLikelihood - oldLogLikelihood
    
    % Smoothing : Calcul des statistiques de la state variable nécessaires
    [C_s,M_s,X] = kalman_smoother(R,C,G,M,c);
    
    % Mis à jour des nouveaux coeff du système : F,G,c,d,W,V
    [G,c,W,F,d,V]=matricesUpdater(y,M_s,C_s,X,F,W,G);
    
    % MAJ of OldLikelihood
    oldLogLikelihood = currentLogLikelihood;
    
    
    if isequal(nbIteration,maxiter)
        break;
    end;
end;

% Filtrer à nouveau avec les nouveaux coeff pour avoir une state variable
% bien définie
[M,C,R,likelihood] = kalman_filter(y,x0,C0,c,G,W,d,F,V);

%% Plot and finishing
[k,mu_e,sigma_x,sigma_e,p_xe,lambda_e,lambda_x] = parametersExtraction(c,G,W,d,F,dt,maturity);
% Création de l'objet de série temporelle

x0out = M(1,1)
e0out = M(2,1)
M_ts = exp(M(1,:)+M(2,:));
end