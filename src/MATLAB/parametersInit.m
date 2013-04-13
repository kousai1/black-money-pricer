function [k,mu_e,sigma_x,sigma_e,p_xe,lambda_e,lambda_x,VarError] = parametersInit()

% %% Paper Schwartz and Smith guess
% % Initialization Theta = [k,mu_e,sigma_x,sigma_e,p_xe,lambda_e,lambda_x]
% % Cf. Paper : Theta=[1.49,.03,.286,.145,.3,.0415,.157]
% 
% k = 1.49;
% mu_e = 0.03;
% sigma_x = 0.286;
% sigma_e = 0.145;
% p_xe = 0.3;
% lambda_e = 0.0415;
% lambda_x = 0.157;
% 
% % Initialisation de la matrice de covariance des erreurs de mesure
% % VarError = [.042;.006;.003;.0000;.004]; % Donné dans le paper, c'est la
% % matrice V = initialisation des erreurs de mesures
% 
% VarError = [.042;.006;.003;.0000;.004];
% % VarError=[.001;.001;.001;.001;.001];

%% Our Guessing / Test for EM
% Initialisation : For EM TESTING : to modify

k = 1;
mu_e = 0.05;
sigma_x = 0.1;
sigma_e = 0.1;
p_xe = 0.5;
lambda_e = 0;
lambda_x = 0.1;

% Initialisation de la matrice de covariance des erreurs de mesure
 VarError = [.042;.006;.003;.0000;.004]; % Donné dans le paper, c'est la
% matrice V = initialisation des erreurs de mesures

%VarError=[0.005;0.005;0.005;0.005;0.005];
