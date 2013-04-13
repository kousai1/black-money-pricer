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

namespace SchwartzNative
{

  /// <summary>
  /// The Schwartz class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
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
    /// Provides a single output, 0-input Objectinterface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object SchwartzAndSmith()
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="maxiter">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object SchwartzAndSmith(Object maxiter)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the SchwartzAndSmith
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="maxiter">Input argument #1</param>
    /// <param name="x0">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object SchwartzAndSmith(Object maxiter, Object x0)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the SchwartzAndSmith
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object SchwartzAndSmith(Object maxiter, Object x0, Object e0)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0, e0);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the SchwartzAndSmith
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object SchwartzAndSmith(Object maxiter, Object x0, Object e0, Object maturity)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0, e0, maturity);
    }


    /// <summary>
    /// Provides a single output, 5-input Objectinterface to the SchwartzAndSmith
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object SchwartzAndSmith(Object maxiter, Object x0, Object e0, Object maturity, 
                             Object y)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0, e0, maturity, y);
    }


    /// <summary>
    /// Provides a single output, 6-input Objectinterface to the SchwartzAndSmith
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object SchwartzAndSmith(Object maxiter, Object x0, Object e0, Object maturity, 
                             Object y, Object k_in1)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1);
    }


    /// <summary>
    /// Provides a single output, 7-input Objectinterface to the SchwartzAndSmith
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object SchwartzAndSmith(Object maxiter, Object x0, Object e0, Object maturity, 
                             Object y, Object k_in1, Object mu_e_in1)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1);
    }


    /// <summary>
    /// Provides a single output, 8-input Objectinterface to the SchwartzAndSmith
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object SchwartzAndSmith(Object maxiter, Object x0, Object e0, Object maturity, 
                             Object y, Object k_in1, Object mu_e_in1, Object sigma_x_in1)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1, sigma_x_in1);
    }


    /// <summary>
    /// Provides a single output, 9-input Objectinterface to the SchwartzAndSmith
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object SchwartzAndSmith(Object maxiter, Object x0, Object e0, Object maturity, 
                             Object y, Object k_in1, Object mu_e_in1, Object sigma_x_in1, 
                             Object sigma_e_in1)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1, sigma_x_in1, sigma_e_in1);
    }


    /// <summary>
    /// Provides a single output, 10-input Objectinterface to the SchwartzAndSmith
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object SchwartzAndSmith(Object maxiter, Object x0, Object e0, Object maturity, 
                             Object y, Object k_in1, Object mu_e_in1, Object sigma_x_in1, 
                             Object sigma_e_in1, Object p_xe_in1)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1, sigma_x_in1, sigma_e_in1, p_xe_in1);
    }


    /// <summary>
    /// Provides a single output, 11-input Objectinterface to the SchwartzAndSmith
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object SchwartzAndSmith(Object maxiter, Object x0, Object e0, Object maturity, 
                             Object y, Object k_in1, Object mu_e_in1, Object sigma_x_in1, 
                             Object sigma_e_in1, Object p_xe_in1, Object lambda_e_in1)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1, sigma_x_in1, sigma_e_in1, p_xe_in1, lambda_e_in1);
    }


    /// <summary>
    /// Provides a single output, 12-input Objectinterface to the SchwartzAndSmith
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
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object SchwartzAndSmith(Object maxiter, Object x0, Object e0, Object maturity, 
                             Object y, Object k_in1, Object mu_e_in1, Object sigma_x_in1, 
                             Object sigma_e_in1, Object p_xe_in1, Object lambda_e_in1, 
                             Object lambda_x_in1)
    {
      return mcr.EvaluateFunction("SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1, sigma_x_in1, sigma_e_in1, p_xe_in1, lambda_e_in1, lambda_x_in1);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the SchwartzAndSmith
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
    public Object[] SchwartzAndSmith(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the SchwartzAndSmith
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
    public Object[] SchwartzAndSmith(int numArgsOut, Object maxiter)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the SchwartzAndSmith
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
    public Object[] SchwartzAndSmith(int numArgsOut, Object maxiter, Object x0)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the SchwartzAndSmith
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
    public Object[] SchwartzAndSmith(int numArgsOut, Object maxiter, Object x0, Object e0)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0, e0);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the SchwartzAndSmith
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
    public Object[] SchwartzAndSmith(int numArgsOut, Object maxiter, Object x0, Object 
                               e0, Object maturity)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0, e0, maturity);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the SchwartzAndSmith
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
    public Object[] SchwartzAndSmith(int numArgsOut, Object maxiter, Object x0, Object 
                               e0, Object maturity, Object y)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0, e0, maturity, y);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the SchwartzAndSmith
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
    public Object[] SchwartzAndSmith(int numArgsOut, Object maxiter, Object x0, Object 
                               e0, Object maturity, Object y, Object k_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1);
    }


    /// <summary>
    /// Provides the standard 7-input Object interface to the SchwartzAndSmith
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
    public Object[] SchwartzAndSmith(int numArgsOut, Object maxiter, Object x0, Object 
                               e0, Object maturity, Object y, Object k_in1, Object 
                               mu_e_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1);
    }


    /// <summary>
    /// Provides the standard 8-input Object interface to the SchwartzAndSmith
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
    public Object[] SchwartzAndSmith(int numArgsOut, Object maxiter, Object x0, Object 
                               e0, Object maturity, Object y, Object k_in1, Object 
                               mu_e_in1, Object sigma_x_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1, sigma_x_in1);
    }


    /// <summary>
    /// Provides the standard 9-input Object interface to the SchwartzAndSmith
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
    public Object[] SchwartzAndSmith(int numArgsOut, Object maxiter, Object x0, Object 
                               e0, Object maturity, Object y, Object k_in1, Object 
                               mu_e_in1, Object sigma_x_in1, Object sigma_e_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1, sigma_x_in1, sigma_e_in1);
    }


    /// <summary>
    /// Provides the standard 10-input Object interface to the SchwartzAndSmith
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
    public Object[] SchwartzAndSmith(int numArgsOut, Object maxiter, Object x0, Object 
                               e0, Object maturity, Object y, Object k_in1, Object 
                               mu_e_in1, Object sigma_x_in1, Object sigma_e_in1, Object 
                               p_xe_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1, sigma_x_in1, sigma_e_in1, p_xe_in1);
    }


    /// <summary>
    /// Provides the standard 11-input Object interface to the SchwartzAndSmith
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
    public Object[] SchwartzAndSmith(int numArgsOut, Object maxiter, Object x0, Object 
                               e0, Object maturity, Object y, Object k_in1, Object 
                               mu_e_in1, Object sigma_x_in1, Object sigma_e_in1, Object 
                               p_xe_in1, Object lambda_e_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1, sigma_x_in1, sigma_e_in1, p_xe_in1, lambda_e_in1);
    }


    /// <summary>
    /// Provides the standard 12-input Object interface to the SchwartzAndSmith
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
    public Object[] SchwartzAndSmith(int numArgsOut, Object maxiter, Object x0, Object 
                               e0, Object maturity, Object y, Object k_in1, Object 
                               mu_e_in1, Object sigma_x_in1, Object sigma_e_in1, Object 
                               p_xe_in1, Object lambda_e_in1, Object lambda_x_in1)
    {
      return mcr.EvaluateFunction(numArgsOut, "SchwartzAndSmith", maxiter, x0, e0, maturity, y, k_in1, mu_e_in1, sigma_x_in1, sigma_e_in1, p_xe_in1, lambda_e_in1, lambda_x_in1);
    }


    /// <summary>
    /// Provides an interface for the SchwartzAndSmith function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Script: MAIN - fonction principale du programme
    /// Permet la vue globable sur tout le processing
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("SchwartzAndSmith", 12, 12, 0)]
    protected void SchwartzAndSmith(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("SchwartzAndSmith", numArgsOut, ref argsOut, argsIn, varArgsIn);
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
