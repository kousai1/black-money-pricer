function [G,c,W,F,d,V] = matricesUpdater(y,M_s,C_s,X,F,W,G)
%MATRICESUPDATER -  Mise à jour des matrices du modèle espace-état
%   Définit les nouvelles matrices tel que on maximise la
%   fonction de vraisemblance d'observer x et y

NumObs= size(y,2);
NbCont= size(y,1);


% Allocations
K_t_t = zeros(2,2,NumObs);
K_t_t1 = zeros(2,2,NumObs-1); % Il utilise l'autocovariance d'où la taille
V = zeros(NbCont,NbCont);
c = zeros(2,1);


% Computation of K_t_t and K_t_t-1
for i = 1 : NumObs
    K_t_t(:,:,i) = C_s(:,:,i) + M_s(:,i)*M_s(:,i)';
end

for i = 2 : NumObs
   K_t_t1(:,:,i-1) = X(:,:,i-1) + M_s(:,i)*M_s(:,i-1)';
end


% Variables des formules
sumK_t_t = sum(K_t_t,3); % sum de tous les K_t_t (donc selon la 3ème dimension)
sumSmoothedState = sum(M_s,2);
sumObservedData = sum(y,2);
sumSmoothedState2_T = sum(M_s(:,2:NumObs),2);
sumSmoothedState1_T1 = sum(M_s(:,1:NumObs-1),2);


% d Updating
d =(sumObservedData-F*sumSmoothedState);
d = d/NumObs;


% F Updating
for j = 1 : NbCont 
    temp1=0;
    temp2=0;
    
    for i = 1 : NumObs
        temp1 = temp1 + y(j,i)*M_s(1,i);
    end
    temp2 = temp2 + d(j)*sumSmoothedState(1,1);
    
%     str=sprintf('a letape %i, on a : %f',j,sumSmoothedState(1,1));
%     disp(str);
    
    F(j,1) = (temp1 - temp2 - sumK_t_t(2,1))/sumK_t_t(1,1); 
end

% V Updating
for i = 1 : NbCont
    temp1 = 0;
    for t = 1 : NumObs
        temp1 = temp1 + (y(i,t) - d(i))^2 - 2*(y(i,t)-d(i))*(M_s(1,t)*F(i,1)+M_s(2,t));
    end
    temp2 = sumK_t_t(1,1)*F(i,1)^2 + 2*sumK_t_t(2,1)*F(i,1)+sumK_t_t(2,2);
    V(i,i) = (temp1 + temp2)/NumObs;
end


% c Updating
invW = inv(W);
temp1 = invW(1,2)*sumSmoothedState2_T(1,1)+invW(2,2)*sumSmoothedState2_T(2,1);
temp2 = invW(2,1)*G(1,1)*sumSmoothedState1_T1(1,1) + invW(2,2)*sumSmoothedState1_T1(2,1);

% disp(sumSmoothedState2_T(1,1));
% disp(sumSmoothedState2_T(2,1));
% disp(sumSmoothedState1_T1(1,1));
% disp(sumSmoothedState1_T1(2,1));
% disp('temp2');
% disp(invW);

c(2,1) = (1 / ((NumObs - 1)*invW(2,2)))*(temp1-temp2);


% G Updating 
sumK_t1_t1= sum(K_t_t(:,:,1:NumObs-1),3);
sumK_t_t1= sum(K_t_t1,3);

%temp1 = invW(1,1)*sumK_t_t1(1,1) - invW(1,2)*sumK_t_t1(2,1); A VERIFIER pr
%les instants t et t1

temp1 = invW(1,1)*sumK_t_t1(1,1) - invW(1,2)*sumK_t1_t1(2,1);
temp2 = invW(2,1)*(sumK_t_t1(1,2) - c(2,1)*sumSmoothedState1_T1(1,1));

G(1,1) = (1/(invW(1,1)*sumK_t1_t1(1,1)))*(temp1+temp2);


% W Updating
temp1 = 0;
temp2 = 0;

for t = 2 : NumObs   
    temp1 = temp1 + K_t_t(:,:,t) - M_s(:,t)*c' - K_t_t1(:,:,t-1)*G' - c*M_s(:,t)' + c*c';
    temp2 = temp2 + c*M_s(:,t-1)'*G' - G*K_t_t1(:,:,t-1)' + G*M_s(:,t-1)*c' + G*K_t_t(:,:,t-1)*G';
end

W = (1/(NumObs-1))*(temp1+temp2);

end

