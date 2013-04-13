function y = simuY(W, V, G, F, c, d, T, loading)
%SIMUY - Purpose = Simulation of a data set observed

y = zeros(size(F,1),T);

% Simulation of futures
if (loading == 0)
    
    w=chol(W)*randn(length(W),T);
    q=chol(V)*randn(length(V),T);
    
    % y Generation - Random - Cf. Internet Code
    x(:,1)=[0;0];
    
    for i = 1 : T-1
        
        x(:,i+1) = c + G*x(:,i) + w(:,i);
        y(:,i+1) = d + F*x(:,i+1) + q(:,i);
    
    end;
    
else if loading == 1 load('y.mat','y');
        
    else temp = importdata('crudeoil.txt','\t');
        y = temp';
    end;
end;

% fid = fopen('y.txt', 'w');

% for i = 1 : size(y,1)
%     for j = 1 : size(y,2)
%         fprintf(fid,'%f\t', y(i,j));
%     end
%     fprintf(fid,'\n\n%i\t',i);
% end

% 2ème méthode
% save('y.mat','y');

end

