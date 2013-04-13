%%  Build Script
% This script will build the mcode for the CSharp_MATLAB demo.
%
% This demo shows the integration of MATLAB with C# in three
% distinct fashions.  See the included readme.doc for more
% information.
%
% The bulk of the demo is written in C# and referenced in the 
% Visual Studio project.  The example MATLAB code used,
% "math_on_numbers.m," is a user submitted code snippet that
% motivated the demo.
%
% Copyright 2006,2010 The MathWorks, Inc.


%% Determine path names
workdir = pwd();

basedir = fileparts(workdir);

dnetdir = fullfile(workdir, 'dotnet');

%% Determine file names
mfile = fullfile(workdir, 'SchwartzAndSmith.m');

dnetdll = fullfile(dnetdir, 'Schwartz.dll');



%% Verify m file can be found
if (exist(mfile, 'file') ~= 2)
    error('Unable to fine mfile math_on_numbers.m');
end



if (exist(dnetdir, 'dir') ~= 7)
    mkdir(dnetdir);
end

%% Build .NET Assembly
disp('Compiling .NET Assembly...');

eval(['mcc -N -d ' dnetdir ' -W ''dotnet:Schwartz,' ...
        'SSComputer,0.0,private'' -T link:lib ' mfile]);

% verify assembly was created
if (exist(dnetdll, 'file') ~= 2) 
    error('Failed to successfully compile .NET assembly.');
else
    fprintf('\tDone\n');
end

