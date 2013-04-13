/*
* MATLAB Compiler: 4.15 (R2011a)
* Date: Fri Apr 06 20:30:21 2012
* Arguments: "-B" "macro_default" "-W" "dotnet:Schwartz,Schwartz,0.0,private" "-T"
* "link:lib" "-d" "C:\Users\Clément\Desktop\ppe_copp\EM\Schwartz\src" "-w"
* "enable:specified_file_mismatch" "-w" "enable:repeated_file" "-w"
* "enable:switch_ignored" "-w" "enable:missing_lib_sentinel" "-w" "enable:demo_license"
* "-v" "class{Schwartz:C:\Users\Clément\Desktop\ppe_copp\EM\SchwartzAndSmith.m}" "-a"
* "C:\Users\Clément\Desktop\ppe_copp\EM\buildMatrices.m" "-a"
* "C:\Users\Clément\Desktop\ppe_copp\EM\kalman_filter.m" "-a"
* "C:\Users\Clément\Desktop\ppe_copp\EM\kalman_smoother.m" "-a"
* "C:\Users\Clément\Desktop\ppe_copp\EM\matricesUpdater.m" "-a"
* "C:\Users\Clément\Desktop\ppe_copp\EM\parametersExtraction.m" "-a"
* "C:\Users\Clément\Desktop\ppe_copp\EM\parametersInit.m" "-a"
* "C:\Users\Clément\Desktop\ppe_copp\EM\simuY.m" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace Schwartz
{

  /// <summary>
  /// The Schwartz class provides a CLS compliant, MWArray interface to the M-functions
  /// contained in the files:
  /// <newpara></newpara>
  /// C:\Users\Clément\Desktop\ppe_copp\EM\SchwartzAndSmith.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class Schwartz : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static Schwartz()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = "Schwartz.ctf";

        Stream embeddedCtfStream = null;

        String[] resourceStrings = assembly.GetManifestResourceNames();

        foreach (String name in resourceStrings)
        {
          if (name.Contains(ctfFileName))
          {
            embeddedCtfStream = assembly.GetManifestResourceStream(name);
            break;
          }
        }
        mcr= new MWMCR("",
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the Schwartz class.
    /// </summary>
    public Schwartz()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Schwartz()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray SchwartzAndSmith()
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="maxiter">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray SchwartzAndSmith(MWArray maxiter)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray SchwartzAndSmith(MWArray maxiter, MWArray x0)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <param name="e0">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray SchwartzAndSmith(MWArray maxiter, MWArray x0, MWArray e0)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0, e0);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <param name="e0">Input argument #3</param>
    /// <param name="maturity">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray SchwartzAndSmith(MWArray maxiter, MWArray x0, MWArray e0, MWArray 
                              maturity)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0, e0, maturity);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <param name="e0">Input argument #3</param>
    /// <param name="maturity">Input argument #4</param>
    /// <param name="y">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray SchwartzAndSmith(MWArray maxiter, MWArray x0, MWArray e0, MWArray 
                              maturity, MWArray y)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0, e0, maturity, y);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <param name="e0">Input argument #3</param>
    /// <param name="maturity">Input argument #4</param>
    /// <param name="y">Input argument #5</param>
    /// <param name="k_in1">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray SchwartzAndSmith(MWArray maxiter, MWArray x0, MWArray e0, MWArray 
                              maturity, MWArray y, MWArray k_in1)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <param name="e0">Input argument #3</param>
    /// <param name="maturity">Input argument #4</param>
    /// <param name="y">Input argument #5</param>
    /// <param name="k_in1">Input argument #6</param>
    /// <param name="mu_e_in1">Input argument #7</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray SchwartzAndSmith(MWArray maxiter, MWArray x0, MWArray e0, MWArray 
                              maturity, MWArray y, MWArray k_in1, MWArray mu_e_in1)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1);
    }


    /// <summary>
    /// Provides a single output, 8-input MWArrayinterface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <param name="e0">Input argument #3</param>
    /// <param name="maturity">Input argument #4</param>
    /// <param name="y">Input argument #5</param>
    /// <param name="k_in1">Input argument #6</param>
    /// <param name="mu_e_in1">Input argument #7</param>
    /// <param name="sigma_x_in1">Input argument #8</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray SchwartzAndSmith(MWArray maxiter, MWArray x0, MWArray e0, MWArray 
                              maturity, MWArray y, MWArray k_in1, MWArray mu_e_in1, 
                              MWArray sigma_x_in1)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1, sigma_x_in1);
    }


    /// <summary>
    /// Provides a single output, 9-input MWArrayinterface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <param name="e0">Input argument #3</param>
    /// <param name="maturity">Input argument #4</param>
    /// <param name="y">Input argument #5</param>
    /// <param name="k_in1">Input argument #6</param>
    /// <param name="mu_e_in1">Input argument #7</param>
    /// <param name="sigma_x_in1">Input argument #8</param>
    /// <param name="sigma_e_in1">Input argument #9</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray SchwartzAndSmith(MWArray maxiter, MWArray x0, MWArray e0, MWArray 
                              maturity, MWArray y, MWArray k_in1, MWArray mu_e_in1, 
                              MWArray sigma_x_in1, MWArray sigma_e_in1)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1, sigma_x_in1, sigma_e_in1);
    }


    /// <summary>
    /// Provides a single output, 10-input MWArrayinterface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <param name="e0">Input argument #3</param>
    /// <param name="maturity">Input argument #4</param>
    /// <param name="y">Input argument #5</param>
    /// <param name="k_in1">Input argument #6</param>
    /// <param name="mu_e_in1">Input argument #7</param>
    /// <param name="sigma_x_in1">Input argument #8</param>
    /// <param name="sigma_e_in1">Input argument #9</param>
    /// <param name="p_xe_in1">Input argument #10</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray SchwartzAndSmith(MWArray maxiter, MWArray x0, MWArray e0, MWArray 
                              maturity, MWArray y, MWArray k_in1, MWArray mu_e_in1, 
                              MWArray sigma_x_in1, MWArray sigma_e_in1, MWArray p_xe_in1)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1, sigma_x_in1, sigma_e_in1, p_xe_in1);
    }


    /// <summary>
    /// Provides a single output, 11-input MWArrayinterface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <param name="e0">Input argument #3</param>
    /// <param name="maturity">Input argument #4</param>
    /// <param name="y">Input argument #5</param>
    /// <param name="k_in1">Input argument #6</param>
    /// <param name="mu_e_in1">Input argument #7</param>
    /// <param name="sigma_x_in1">Input argument #8</param>
    /// <param name="sigma_e_in1">Input argument #9</param>
    /// <param name="p_xe_in1">Input argument #10</param>
    /// <param name="lambda_e_in1">Input argument #11</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray SchwartzAndSmith(MWArray maxiter, MWArray x0, MWArray e0, MWArray 
                              maturity, MWArray y, MWArray k_in1, MWArray mu_e_in1, 
                              MWArray sigma_x_in1, MWArray sigma_e_in1, MWArray p_xe_in1, 
                              MWArray lambda_e_in1)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1, sigma_x_in1, sigma_e_in1, p_xe_in1, lambda_e_in1);
    }


    /// <summary>
    /// Provides a single output, 12-input MWArrayinterface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <param name="e0">Input argument #3</param>
    /// <param name="maturity">Input argument #4</param>
    /// <param name="y">Input argument #5</param>
    /// <param name="k_in1">Input argument #6</param>
    /// <param name="mu_e_in1">Input argument #7</param>
    /// <param name="sigma_x_in1">Input argument #8</param>
    /// <param name="sigma_e_in1">Input argument #9</param>
    /// <param name="p_xe_in1">Input argument #10</param>
    /// <param name="lambda_e_in1">Input argument #11</param>
    /// <param name="lambda_x_in1">Input argument #12</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray SchwartzAndSmith(MWArray maxiter, MWArray x0, MWArray e0, MWArray 
                              maturity, MWArray y, MWArray k_in1, MWArray mu_e_in1, 
                              MWArray sigma_x_in1, MWArray sigma_e_in1, MWArray p_xe_in1, 
                              MWArray lambda_e_in1, MWArray lambda_x_in1)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1, sigma_x_in1, sigma_e_in1, p_xe_in1, lambda_e_in1, lambda_x_in1);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] SchwartzAndSmith(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="maxiter">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] SchwartzAndSmith(int numArgsOut, MWArray maxiter)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] SchwartzAndSmith(int numArgsOut, MWArray maxiter, MWArray x0)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <param name="e0">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] SchwartzAndSmith(int numArgsOut, MWArray maxiter, MWArray x0, 
                                MWArray e0)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0, e0);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <param name="e0">Input argument #3</param>
    /// <param name="maturity">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] SchwartzAndSmith(int numArgsOut, MWArray maxiter, MWArray x0, 
                                MWArray e0, MWArray maturity)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0, e0, maturity);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <param name="e0">Input argument #3</param>
    /// <param name="maturity">Input argument #4</param>
    /// <param name="y">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] SchwartzAndSmith(int numArgsOut, MWArray maxiter, MWArray x0, 
                                MWArray e0, MWArray maturity, MWArray y)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0, e0, maturity, y);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <param name="e0">Input argument #3</param>
    /// <param name="maturity">Input argument #4</param>
    /// <param name="y">Input argument #5</param>
    /// <param name="k_in1">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] SchwartzAndSmith(int numArgsOut, MWArray maxiter, MWArray x0, 
                                MWArray e0, MWArray maturity, MWArray y, MWArray k_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <param name="e0">Input argument #3</param>
    /// <param name="maturity">Input argument #4</param>
    /// <param name="y">Input argument #5</param>
    /// <param name="k_in1">Input argument #6</param>
    /// <param name="mu_e_in1">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] SchwartzAndSmith(int numArgsOut, MWArray maxiter, MWArray x0, 
                                MWArray e0, MWArray maturity, MWArray y, MWArray k_in1, 
                                MWArray mu_e_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <param name="e0">Input argument #3</param>
    /// <param name="maturity">Input argument #4</param>
    /// <param name="y">Input argument #5</param>
    /// <param name="k_in1">Input argument #6</param>
    /// <param name="mu_e_in1">Input argument #7</param>
    /// <param name="sigma_x_in1">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] SchwartzAndSmith(int numArgsOut, MWArray maxiter, MWArray x0, 
                                MWArray e0, MWArray maturity, MWArray y, MWArray k_in1, 
                                MWArray mu_e_in1, MWArray sigma_x_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1, sigma_x_in1);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <param name="e0">Input argument #3</param>
    /// <param name="maturity">Input argument #4</param>
    /// <param name="y">Input argument #5</param>
    /// <param name="k_in1">Input argument #6</param>
    /// <param name="mu_e_in1">Input argument #7</param>
    /// <param name="sigma_x_in1">Input argument #8</param>
    /// <param name="sigma_e_in1">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] SchwartzAndSmith(int numArgsOut, MWArray maxiter, MWArray x0, 
                                MWArray e0, MWArray maturity, MWArray y, MWArray k_in1, 
                                MWArray mu_e_in1, MWArray sigma_x_in1, MWArray 
                                sigma_e_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1, sigma_x_in1, sigma_e_in1);
    }


    /// <summary>
    /// Provides the standard 10-input MWArray interface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <param name="e0">Input argument #3</param>
    /// <param name="maturity">Input argument #4</param>
    /// <param name="y">Input argument #5</param>
    /// <param name="k_in1">Input argument #6</param>
    /// <param name="mu_e_in1">Input argument #7</param>
    /// <param name="sigma_x_in1">Input argument #8</param>
    /// <param name="sigma_e_in1">Input argument #9</param>
    /// <param name="p_xe_in1">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] SchwartzAndSmith(int numArgsOut, MWArray maxiter, MWArray x0, 
                                MWArray e0, MWArray maturity, MWArray y, MWArray k_in1, 
                                MWArray mu_e_in1, MWArray sigma_x_in1, MWArray 
                                sigma_e_in1, MWArray p_xe_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1, sigma_x_in1, sigma_e_in1, p_xe_in1);
    }


    /// <summary>
    /// Provides the standard 11-input MWArray interface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <param name="e0">Input argument #3</param>
    /// <param name="maturity">Input argument #4</param>
    /// <param name="y">Input argument #5</param>
    /// <param name="k_in1">Input argument #6</param>
    /// <param name="mu_e_in1">Input argument #7</param>
    /// <param name="sigma_x_in1">Input argument #8</param>
    /// <param name="sigma_e_in1">Input argument #9</param>
    /// <param name="p_xe_in1">Input argument #10</param>
    /// <param name="lambda_e_in1">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] SchwartzAndSmith(int numArgsOut, MWArray maxiter, MWArray x0, 
                                MWArray e0, MWArray maturity, MWArray y, MWArray k_in1, 
                                MWArray mu_e_in1, MWArray sigma_x_in1, MWArray 
                                sigma_e_in1, MWArray p_xe_in1, MWArray lambda_e_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1, sigma_x_in1, sigma_e_in1, p_xe_in1, lambda_e_in1);
    }


    /// <summary>
    /// Provides the standard 12-input MWArray interface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <param name="e0">Input argument #3</param>
    /// <param name="maturity">Input argument #4</param>
    /// <param name="y">Input argument #5</param>
    /// <param name="k_in1">Input argument #6</param>
    /// <param name="mu_e_in1">Input argument #7</param>
    /// <param name="sigma_x_in1">Input argument #8</param>
    /// <param name="sigma_e_in1">Input argument #9</param>
    /// <param name="p_xe_in1">Input argument #10</param>
    /// <param name="lambda_e_in1">Input argument #11</param>
    /// <param name="lambda_x_in1">Input argument #12</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] SchwartzAndSmith(int numArgsOut, MWArray maxiter, MWArray x0, 
                                MWArray e0, MWArray maturity, MWArray y, MWArray k_in1, 
                                MWArray mu_e_in1, MWArray sigma_x_in1, MWArray 
                                sigma_e_in1, MWArray p_xe_in1, MWArray lambda_e_in1, 
                                MWArray lambda_x_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1, sigma_x_in1, sigma_e_in1, p_xe_in1, lambda_e_in1, lambda_x_in1);
    }


    /// <summary>
    /// Provides an interface for the SchwartzAndSmith function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void SchwartzAndSmith(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("SchwartzAndSmith", numArgsOut, ref argsOut, argsIn);
    }



    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
