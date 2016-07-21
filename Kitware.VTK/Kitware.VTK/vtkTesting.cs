using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTesting : vtkObject
	{
		public enum ReturnValue
		{
			DO_INTERACTOR = 3,
			FAILED = 0,
			NOT_RUN = 2,
			PASSED = 1
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkTesting";

		public new static readonly string MRClassNameKey;

		static vtkTesting()
		{
			vtkTesting.MRClassNameKey = "class vtkTesting";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTesting.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTesting"));
		}

		public vtkTesting(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTesting_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTesting New()
		{
			vtkTesting result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTesting.vtkTesting_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTesting)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTesting() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTesting.vtkTesting_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTesting_AddArgument_01(HandleRef pThis, string argv);

		public void AddArgument(string argv)
		{
			vtkTesting.vtkTesting_AddArgument_01(base.GetCppThis(), argv);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTesting_AddArguments_02(HandleRef pThis, int argc, [In] [Out] string[] argv);

		public void AddArguments(string[] argv)
		{
			vtkTesting.vtkTesting_AddArguments_02(base.GetCppThis(), argv.Length, argv);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTesting_CleanArguments_03(HandleRef pThis);

		public void CleanArguments()
		{
			vtkTesting.vtkTesting_CleanArguments_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTesting_CompareAverageOfL2Norm_04(HandleRef pThis, HandleRef pdA, HandleRef pdB, double tol);

		public int CompareAverageOfL2Norm(vtkDataSet pdA, vtkDataSet pdB, double tol)
		{
			return vtkTesting.vtkTesting_CompareAverageOfL2Norm_04(base.GetCppThis(), (pdA == null) ? default(HandleRef) : pdA.GetCppThis(), (pdB == null) ? default(HandleRef) : pdB.GetCppThis(), tol);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTesting_CompareAverageOfL2Norm_05(HandleRef pThis, HandleRef daA, HandleRef daB, double tol);

		public int CompareAverageOfL2Norm(vtkDataArray daA, vtkDataArray daB, double tol)
		{
			return vtkTesting.vtkTesting_CompareAverageOfL2Norm_05(base.GetCppThis(), (daA == null) ? default(HandleRef) : daA.GetCppThis(), (daB == null) ? default(HandleRef) : daB.GetCppThis(), tol);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTesting_FrontBufferOff_06(HandleRef pThis);

		public virtual void FrontBufferOff()
		{
			vtkTesting.vtkTesting_FrontBufferOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTesting_FrontBufferOn_07(HandleRef pThis);

		public virtual void FrontBufferOn()
		{
			vtkTesting.vtkTesting_FrontBufferOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTesting_GetArgument_08(HandleRef pThis, string arg);

		public string GetArgument(string arg)
		{
			return Marshal.PtrToStringAnsi(vtkTesting.vtkTesting_GetArgument_08(base.GetCppThis(), arg));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTesting_GetBorderOffset_09(HandleRef pThis);

		public virtual int GetBorderOffset()
		{
			return vtkTesting.vtkTesting_GetBorderOffset_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTesting_GetDataRoot_10(HandleRef pThis);

		public string GetDataRoot()
		{
			return Marshal.PtrToStringAnsi(vtkTesting.vtkTesting_GetDataRoot_10(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTesting_GetFrontBuffer_11(HandleRef pThis);

		public virtual int GetFrontBuffer()
		{
			return vtkTesting.vtkTesting_GetFrontBuffer_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTesting_GetFrontBufferMaxValue_12(HandleRef pThis);

		public virtual int GetFrontBufferMaxValue()
		{
			return vtkTesting.vtkTesting_GetFrontBufferMaxValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTesting_GetFrontBufferMinValue_13(HandleRef pThis);

		public virtual int GetFrontBufferMinValue()
		{
			return vtkTesting.vtkTesting_GetFrontBufferMinValue_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkTesting_GetImageDifference_14(HandleRef pThis);

		public virtual double GetImageDifference()
		{
			return vtkTesting.vtkTesting_GetImageDifference_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTesting_GetRenderWindow_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderWindow GetRenderWindow()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTesting.vtkTesting_GetRenderWindow_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindow = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindow.Register(null);
				}
			}
			return vtkRenderWindow;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTesting_GetTempDirectory_16(HandleRef pThis);

		public string GetTempDirectory()
		{
			return Marshal.PtrToStringAnsi(vtkTesting.vtkTesting_GetTempDirectory_16(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTesting_GetValidImageFileName_17(HandleRef pThis);

		public string GetValidImageFileName()
		{
			return Marshal.PtrToStringAnsi(vtkTesting.vtkTesting_GetValidImageFileName_17(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTesting_GetVerbose_18(HandleRef pThis);

		public virtual int GetVerbose()
		{
			return vtkTesting.vtkTesting_GetVerbose_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTesting_InteractorEventLoop_19(int argc, [In] [Out] string[] argv, HandleRef iren, string stream);

		public static int InteractorEventLoop(string[] argv, vtkRenderWindowInteractor iren, string stream)
		{
			return vtkTesting.vtkTesting_InteractorEventLoop_19(argv.Length, argv, (iren == null) ? default(HandleRef) : iren.GetCppThis(), stream);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTesting_IsA_20(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTesting.vtkTesting_IsA_20(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTesting_IsFlagSpecified_21(HandleRef pThis, string flag);

		public int IsFlagSpecified(string flag)
		{
			return vtkTesting.vtkTesting_IsFlagSpecified_21(base.GetCppThis(), flag);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTesting_IsInteractiveModeSpecified_22(HandleRef pThis);

		public int IsInteractiveModeSpecified()
		{
			return vtkTesting.vtkTesting_IsInteractiveModeSpecified_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTesting_IsTypeOf_23(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTesting.vtkTesting_IsTypeOf_23(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTesting_IsValidImageSpecified_24(HandleRef pThis);

		public int IsValidImageSpecified()
		{
			return vtkTesting.vtkTesting_IsValidImageSpecified_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTesting_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTesting NewInstance()
		{
			vtkTesting result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTesting.vtkTesting_NewInstance_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTesting)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTesting_RegressionTest_27(HandleRef pThis, double thresh);

		public virtual int RegressionTest(double thresh)
		{
			return vtkTesting.vtkTesting_RegressionTest_27(base.GetCppThis(), thresh);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTesting_RegressionTest_28(HandleRef pThis, HandleRef image, double thresh);

		public virtual int RegressionTest(vtkImageData image, double thresh)
		{
			return vtkTesting.vtkTesting_RegressionTest_28(base.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis(), thresh);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkTesting_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTesting SafeDownCast(vtkObjectBase o)
		{
			vtkTesting vtkTesting = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTesting.vtkTesting_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTesting = (vtkTesting)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTesting.Register(null);
				}
			}
			return vtkTesting;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTesting_SetBorderOffset_30(HandleRef pThis, int _arg);

		public virtual void SetBorderOffset(int _arg)
		{
			vtkTesting.vtkTesting_SetBorderOffset_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTesting_SetDataRoot_31(HandleRef pThis, string _arg);

		public virtual void SetDataRoot(string _arg)
		{
			vtkTesting.vtkTesting_SetDataRoot_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTesting_SetFrontBuffer_32(HandleRef pThis, int _arg);

		public virtual void SetFrontBuffer(int _arg)
		{
			vtkTesting.vtkTesting_SetFrontBuffer_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTesting_SetRenderWindow_33(HandleRef pThis, HandleRef rw);

		public virtual void SetRenderWindow(vtkRenderWindow rw)
		{
			vtkTesting.vtkTesting_SetRenderWindow_33(base.GetCppThis(), (rw == null) ? default(HandleRef) : rw.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTesting_SetTempDirectory_34(HandleRef pThis, string _arg);

		public virtual void SetTempDirectory(string _arg)
		{
			vtkTesting.vtkTesting_SetTempDirectory_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTesting_SetValidImageFileName_35(HandleRef pThis, string _arg);

		public virtual void SetValidImageFileName(string _arg)
		{
			vtkTesting.vtkTesting_SetValidImageFileName_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkTesting_SetVerbose_36(HandleRef pThis, int _arg);

		public virtual void SetVerbose(int _arg)
		{
			vtkTesting.vtkTesting_SetVerbose_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkTesting_Test_37(int argc, [In] [Out] string[] argv, HandleRef rw, double thresh);

		public static int Test(string[] argv, vtkRenderWindow rw, double thresh)
		{
			return vtkTesting.vtkTesting_Test_37(argv.Length, argv, (rw == null) ? default(HandleRef) : rw.GetCppThis(), thresh);
		}
	}
}
