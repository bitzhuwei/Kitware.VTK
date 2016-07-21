using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSurfaceLICPainter : vtkPainter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSurfaceLICPainter";

		public new static readonly string MRClassNameKey;

		static vtkSurfaceLICPainter()
		{
			vtkSurfaceLICPainter.MRClassNameKey = "class vtkSurfaceLICPainter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSurfaceLICPainter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSurfaceLICPainter"));
		}

		public vtkSurfaceLICPainter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSurfaceLICPainter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSurfaceLICPainter New()
		{
			vtkSurfaceLICPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSurfaceLICPainter.vtkSurfaceLICPainter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSurfaceLICPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSurfaceLICPainter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSurfaceLICPainter.vtkSurfaceLICPainter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSurfaceLICPainter_EnableOff_01(HandleRef pThis);

		public virtual void EnableOff()
		{
			vtkSurfaceLICPainter.vtkSurfaceLICPainter_EnableOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSurfaceLICPainter_EnableOn_02(HandleRef pThis);

		public virtual void EnableOn()
		{
			vtkSurfaceLICPainter.vtkSurfaceLICPainter_EnableOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSurfaceLICPainter_EnhancedLICOff_03(HandleRef pThis);

		public virtual void EnhancedLICOff()
		{
			vtkSurfaceLICPainter.vtkSurfaceLICPainter_EnhancedLICOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSurfaceLICPainter_EnhancedLICOn_04(HandleRef pThis);

		public virtual void EnhancedLICOn()
		{
			vtkSurfaceLICPainter.vtkSurfaceLICPainter_EnhancedLICOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkSurfaceLICPainter_GetEnable_05(HandleRef pThis);

		public virtual int GetEnable()
		{
			return vtkSurfaceLICPainter.vtkSurfaceLICPainter_GetEnable_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkSurfaceLICPainter_GetEnhancedLIC_06(HandleRef pThis);

		public virtual int GetEnhancedLIC()
		{
			return vtkSurfaceLICPainter.vtkSurfaceLICPainter_GetEnhancedLIC_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkSurfaceLICPainter_GetLICIntensity_07(HandleRef pThis);

		public virtual double GetLICIntensity()
		{
			return vtkSurfaceLICPainter.vtkSurfaceLICPainter_GetLICIntensity_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkSurfaceLICPainter_GetLICIntensityMaxValue_08(HandleRef pThis);

		public virtual double GetLICIntensityMaxValue()
		{
			return vtkSurfaceLICPainter.vtkSurfaceLICPainter_GetLICIntensityMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkSurfaceLICPainter_GetLICIntensityMinValue_09(HandleRef pThis);

		public virtual double GetLICIntensityMinValue()
		{
			return vtkSurfaceLICPainter.vtkSurfaceLICPainter_GetLICIntensityMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkSurfaceLICPainter_GetLICSuccess_10(HandleRef pThis);

		public int GetLICSuccess()
		{
			return vtkSurfaceLICPainter.vtkSurfaceLICPainter_GetLICSuccess_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkSurfaceLICPainter_GetNumberOfSteps_11(HandleRef pThis);

		public virtual int GetNumberOfSteps()
		{
			return vtkSurfaceLICPainter.vtkSurfaceLICPainter_GetNumberOfSteps_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSurfaceLICPainter_GetOutput_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkDataObject GetOutput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSurfaceLICPainter.vtkSurfaceLICPainter_GetOutput_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkSurfaceLICPainter_GetRenderingPreparationSuccess_13(HandleRef pThis);

		public int GetRenderingPreparationSuccess()
		{
			return vtkSurfaceLICPainter.vtkSurfaceLICPainter_GetRenderingPreparationSuccess_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkSurfaceLICPainter_GetStepSize_14(HandleRef pThis);

		public virtual double GetStepSize()
		{
			return vtkSurfaceLICPainter.vtkSurfaceLICPainter_GetStepSize_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkSurfaceLICPainter_IsA_15(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSurfaceLICPainter.vtkSurfaceLICPainter_IsA_15(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkSurfaceLICPainter_IsSupported_16(HandleRef arg0);

		public static bool IsSupported(vtkRenderWindow arg0)
		{
			return vtkSurfaceLICPainter.vtkSurfaceLICPainter_IsSupported_16((arg0 == null) ? default(HandleRef) : arg0.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkSurfaceLICPainter_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSurfaceLICPainter.vtkSurfaceLICPainter_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSurfaceLICPainter_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSurfaceLICPainter NewInstance()
		{
			vtkSurfaceLICPainter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSurfaceLICPainter.vtkSurfaceLICPainter_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSurfaceLICPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSurfaceLICPainter_ReleaseGraphicsResources_20(HandleRef pThis, HandleRef arg0);

		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkSurfaceLICPainter.vtkSurfaceLICPainter_ReleaseGraphicsResources_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkSurfaceLICPainter_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSurfaceLICPainter SafeDownCast(vtkObjectBase o)
		{
			vtkSurfaceLICPainter vtkSurfaceLICPainter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSurfaceLICPainter.vtkSurfaceLICPainter_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSurfaceLICPainter = (vtkSurfaceLICPainter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSurfaceLICPainter.Register(null);
				}
			}
			return vtkSurfaceLICPainter;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSurfaceLICPainter_SetEnable_22(HandleRef pThis, int _arg);

		public virtual void SetEnable(int _arg)
		{
			vtkSurfaceLICPainter.vtkSurfaceLICPainter_SetEnable_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSurfaceLICPainter_SetEnhancedLIC_23(HandleRef pThis, int _arg);

		public virtual void SetEnhancedLIC(int _arg)
		{
			vtkSurfaceLICPainter.vtkSurfaceLICPainter_SetEnhancedLIC_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSurfaceLICPainter_SetInputArrayToProcess_24(HandleRef pThis, int fieldAssociation, string name);

		public void SetInputArrayToProcess(int fieldAssociation, string name)
		{
			vtkSurfaceLICPainter.vtkSurfaceLICPainter_SetInputArrayToProcess_24(base.GetCppThis(), fieldAssociation, name);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSurfaceLICPainter_SetInputArrayToProcess_25(HandleRef pThis, int fieldAssociation, int fieldAttributeType);

		public void SetInputArrayToProcess(int fieldAssociation, int fieldAttributeType)
		{
			vtkSurfaceLICPainter.vtkSurfaceLICPainter_SetInputArrayToProcess_25(base.GetCppThis(), fieldAssociation, fieldAttributeType);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSurfaceLICPainter_SetLICIntensity_26(HandleRef pThis, double _arg);

		public virtual void SetLICIntensity(double _arg)
		{
			vtkSurfaceLICPainter.vtkSurfaceLICPainter_SetLICIntensity_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSurfaceLICPainter_SetNumberOfSteps_27(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSteps(int _arg)
		{
			vtkSurfaceLICPainter.vtkSurfaceLICPainter_SetNumberOfSteps_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkSurfaceLICPainter_SetStepSize_28(HandleRef pThis, double _arg);

		public virtual void SetStepSize(double _arg)
		{
			vtkSurfaceLICPainter.vtkSurfaceLICPainter_SetStepSize_28(base.GetCppThis(), _arg);
		}
	}
}
