using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageDataLIC2D : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageDataLIC2D";

		public new static readonly string MRClassNameKey;

		static vtkImageDataLIC2D()
		{
			vtkImageDataLIC2D.MRClassNameKey = "class vtkImageDataLIC2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageDataLIC2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDataLIC2D"));
		}

		public vtkImageDataLIC2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDataLIC2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageDataLIC2D New()
		{
			vtkImageDataLIC2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDataLIC2D.vtkImageDataLIC2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataLIC2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageDataLIC2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageDataLIC2D.vtkImageDataLIC2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDataLIC2D_GetContext_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkRenderWindow GetContext()
		{
			vtkRenderWindow vtkRenderWindow = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDataLIC2D.vtkImageDataLIC2D_GetContext_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageDataLIC2D_GetFBOSuccess_02(HandleRef pThis);

		public int GetFBOSuccess()
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_GetFBOSuccess_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageDataLIC2D_GetLICSuccess_03(HandleRef pThis);

		public int GetLICSuccess()
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_GetLICSuccess_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageDataLIC2D_GetMagnification_04(HandleRef pThis);

		public virtual int GetMagnification()
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_GetMagnification_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageDataLIC2D_GetMagnificationMaxValue_05(HandleRef pThis);

		public virtual int GetMagnificationMaxValue()
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_GetMagnificationMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageDataLIC2D_GetMagnificationMinValue_06(HandleRef pThis);

		public virtual int GetMagnificationMinValue()
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_GetMagnificationMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageDataLIC2D_GetOpenGLExtensionsSupported_07(HandleRef pThis);

		public virtual int GetOpenGLExtensionsSupported()
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_GetOpenGLExtensionsSupported_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkImageDataLIC2D_GetStepSize_08(HandleRef pThis);

		public virtual double GetStepSize()
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_GetStepSize_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkImageDataLIC2D_GetStepSizeMaxValue_09(HandleRef pThis);

		public virtual double GetStepSizeMaxValue()
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_GetStepSizeMaxValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkImageDataLIC2D_GetStepSizeMinValue_10(HandleRef pThis);

		public virtual double GetStepSizeMinValue()
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_GetStepSizeMinValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageDataLIC2D_GetSteps_11(HandleRef pThis);

		public virtual int GetSteps()
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_GetSteps_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageDataLIC2D_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageDataLIC2D_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDataLIC2D_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageDataLIC2D NewInstance()
		{
			vtkImageDataLIC2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDataLIC2D.vtkImageDataLIC2D_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataLIC2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkImageDataLIC2D_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageDataLIC2D SafeDownCast(vtkObjectBase o)
		{
			vtkImageDataLIC2D vtkImageDataLIC2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageDataLIC2D.vtkImageDataLIC2D_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDataLIC2D = (vtkImageDataLIC2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDataLIC2D.Register(null);
				}
			}
			return vtkImageDataLIC2D;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkImageDataLIC2D_SetContext_17(HandleRef pThis, HandleRef context);

		public int SetContext(vtkRenderWindow context)
		{
			return vtkImageDataLIC2D.vtkImageDataLIC2D_SetContext_17(base.GetCppThis(), (context == null) ? default(HandleRef) : context.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageDataLIC2D_SetMagnification_18(HandleRef pThis, int _arg);

		public virtual void SetMagnification(int _arg)
		{
			vtkImageDataLIC2D.vtkImageDataLIC2D_SetMagnification_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageDataLIC2D_SetStepSize_19(HandleRef pThis, double _arg);

		public virtual void SetStepSize(double _arg)
		{
			vtkImageDataLIC2D.vtkImageDataLIC2D_SetStepSize_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageDataLIC2D_SetSteps_20(HandleRef pThis, int _arg);

		public virtual void SetSteps(int _arg)
		{
			vtkImageDataLIC2D.vtkImageDataLIC2D_SetSteps_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkImageDataLIC2D_TranslateInputExtent_21(HandleRef pThis, IntPtr inExt, IntPtr inWholeExtent, IntPtr outExt);

		public void TranslateInputExtent(IntPtr inExt, IntPtr inWholeExtent, IntPtr outExt)
		{
			vtkImageDataLIC2D.vtkImageDataLIC2D_TranslateInputExtent_21(base.GetCppThis(), inExt, inWholeExtent, outExt);
		}
	}
}
