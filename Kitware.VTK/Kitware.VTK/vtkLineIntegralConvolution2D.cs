using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLineIntegralConvolution2D : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLineIntegralConvolution2D";

		public new static readonly string MRClassNameKey;

		static vtkLineIntegralConvolution2D()
		{
			vtkLineIntegralConvolution2D.MRClassNameKey = "class vtkLineIntegralConvolution2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLineIntegralConvolution2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLineIntegralConvolution2D"));
		}

		public vtkLineIntegralConvolution2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLineIntegralConvolution2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLineIntegralConvolution2D New()
		{
			vtkLineIntegralConvolution2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLineIntegralConvolution2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLineIntegralConvolution2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_EnhancedLICOff_01(HandleRef pThis);

		public virtual void EnhancedLICOff()
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_EnhancedLICOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_EnhancedLICOn_02(HandleRef pThis);

		public virtual void EnhancedLICOn()
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_EnhancedLICOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLineIntegralConvolution2D_Execute_03(HandleRef pThis);

		public int Execute()
		{
			return vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_Execute_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLineIntegralConvolution2D_Execute_04(HandleRef pThis, IntPtr extent);

		public int Execute(IntPtr extent)
		{
			return vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_Execute_04(base.GetCppThis(), extent);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLineIntegralConvolution2D_GetComponentIds_05(HandleRef pThis);

		public virtual int[] GetComponentIds()
		{
			IntPtr intPtr = vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetComponentIds_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_GetComponentIds_06(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetComponentIds(ref int _arg1, ref int _arg2)
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetComponentIds_06(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_GetComponentIds_07(HandleRef pThis, IntPtr _arg);

		public virtual void GetComponentIds(IntPtr _arg)
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetComponentIds_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLineIntegralConvolution2D_GetEnhancedLIC_08(HandleRef pThis);

		public virtual int GetEnhancedLIC()
		{
			return vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetEnhancedLIC_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLineIntegralConvolution2D_GetGridSpacings_09(HandleRef pThis);

		public virtual double[] GetGridSpacings()
		{
			IntPtr intPtr = vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetGridSpacings_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_GetGridSpacings_10(HandleRef pThis, ref double _arg1, ref double _arg2);

		public virtual void GetGridSpacings(ref double _arg1, ref double _arg2)
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetGridSpacings_10(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_GetGridSpacings_11(HandleRef pThis, IntPtr _arg);

		public virtual void GetGridSpacings(IntPtr _arg)
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetGridSpacings_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLineIntegralConvolution2D_GetLIC_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextureObject GetLIC()
		{
			vtkTextureObject vtkTextureObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetLIC_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextureObject = (vtkTextureObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextureObject.Register(null);
				}
			}
			return vtkTextureObject;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLineIntegralConvolution2D_GetLICForSurface_13(HandleRef pThis);

		public virtual int GetLICForSurface()
		{
			return vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetLICForSurface_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLineIntegralConvolution2D_GetLICStepSize_14(HandleRef pThis);

		public virtual double GetLICStepSize()
		{
			return vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetLICStepSize_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLineIntegralConvolution2D_GetLICStepSizeMaxValue_15(HandleRef pThis);

		public virtual double GetLICStepSizeMaxValue()
		{
			return vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetLICStepSizeMaxValue_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkLineIntegralConvolution2D_GetLICStepSizeMinValue_16(HandleRef pThis);

		public virtual double GetLICStepSizeMinValue()
		{
			return vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetLICStepSizeMinValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLineIntegralConvolution2D_GetMagnification_17(HandleRef pThis);

		public virtual int GetMagnification()
		{
			return vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetMagnification_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLineIntegralConvolution2D_GetMagnificationMaxValue_18(HandleRef pThis);

		public virtual int GetMagnificationMaxValue()
		{
			return vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetMagnificationMaxValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLineIntegralConvolution2D_GetMagnificationMinValue_19(HandleRef pThis);

		public virtual int GetMagnificationMinValue()
		{
			return vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetMagnificationMinValue_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLineIntegralConvolution2D_GetNoise_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextureObject GetNoise()
		{
			vtkTextureObject vtkTextureObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetNoise_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextureObject = (vtkTextureObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextureObject.Register(null);
				}
			}
			return vtkTextureObject;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLineIntegralConvolution2D_GetNumberOfSteps_21(HandleRef pThis);

		public virtual int GetNumberOfSteps()
		{
			return vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetNumberOfSteps_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLineIntegralConvolution2D_GetTransformVectors_22(HandleRef pThis);

		public virtual int GetTransformVectors()
		{
			return vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetTransformVectors_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLineIntegralConvolution2D_GetTransformVectorsMaxValue_23(HandleRef pThis);

		public virtual int GetTransformVectorsMaxValue()
		{
			return vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetTransformVectorsMaxValue_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLineIntegralConvolution2D_GetTransformVectorsMinValue_24(HandleRef pThis);

		public virtual int GetTransformVectorsMinValue()
		{
			return vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetTransformVectorsMinValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLineIntegralConvolution2D_GetVectorField_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTextureObject GetVectorField()
		{
			vtkTextureObject vtkTextureObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_GetVectorField_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextureObject = (vtkTextureObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextureObject.Register(null);
				}
			}
			return vtkTextureObject;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLineIntegralConvolution2D_IsA_26(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_IsA_26(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkLineIntegralConvolution2D_IsSupported_27(HandleRef renWin);

		public static bool IsSupported(vtkRenderWindow renWin)
		{
			return vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_IsSupported_27((renWin == null) ? default(HandleRef) : renWin.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkLineIntegralConvolution2D_IsTypeOf_28(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_IsTypeOf_28(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_LICForSurfaceOff_29(HandleRef pThis);

		public virtual void LICForSurfaceOff()
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_LICForSurfaceOff_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_LICForSurfaceOn_30(HandleRef pThis);

		public virtual void LICForSurfaceOn()
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_LICForSurfaceOn_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLineIntegralConvolution2D_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLineIntegralConvolution2D NewInstance()
		{
			vtkLineIntegralConvolution2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_NewInstance_32(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLineIntegralConvolution2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkLineIntegralConvolution2D_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLineIntegralConvolution2D SafeDownCast(vtkObjectBase o)
		{
			vtkLineIntegralConvolution2D vtkLineIntegralConvolution2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLineIntegralConvolution2D = (vtkLineIntegralConvolution2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLineIntegralConvolution2D.Register(null);
				}
			}
			return vtkLineIntegralConvolution2D;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_SetComponentIds_34(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetComponentIds(int _arg1, int _arg2)
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_SetComponentIds_34(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_SetComponentIds_35(HandleRef pThis, IntPtr _arg);

		public void SetComponentIds(IntPtr _arg)
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_SetComponentIds_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_SetEnhancedLIC_36(HandleRef pThis, int _arg);

		public virtual void SetEnhancedLIC(int _arg)
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_SetEnhancedLIC_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_SetGridSpacings_37(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetGridSpacings(double _arg1, double _arg2)
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_SetGridSpacings_37(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_SetGridSpacings_38(HandleRef pThis, IntPtr _arg);

		public void SetGridSpacings(IntPtr _arg)
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_SetGridSpacings_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_SetLIC_39(HandleRef pThis, HandleRef lic);

		public void SetLIC(vtkTextureObject lic)
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_SetLIC_39(base.GetCppThis(), (lic == null) ? default(HandleRef) : lic.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_SetLICForSurface_40(HandleRef pThis, int _arg);

		public virtual void SetLICForSurface(int _arg)
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_SetLICForSurface_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_SetLICStepSize_41(HandleRef pThis, double _arg);

		public virtual void SetLICStepSize(double _arg)
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_SetLICStepSize_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_SetMagnification_42(HandleRef pThis, int _arg);

		public virtual void SetMagnification(int _arg)
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_SetMagnification_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_SetNoise_43(HandleRef pThis, HandleRef noise);

		public void SetNoise(vtkTextureObject noise)
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_SetNoise_43(base.GetCppThis(), (noise == null) ? default(HandleRef) : noise.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_SetNumberOfSteps_44(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSteps(int _arg)
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_SetNumberOfSteps_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_SetTransformVectors_45(HandleRef pThis, int _arg);

		public virtual void SetTransformVectors(int _arg)
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_SetTransformVectors_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_SetVectorField_46(HandleRef pThis, HandleRef vectorField);

		public void SetVectorField(vtkTextureObject vectorField)
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_SetVectorField_46(base.GetCppThis(), (vectorField == null) ? default(HandleRef) : vectorField.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_SetVectorShiftScale_47(HandleRef pThis, double shift, double scale);

		public void SetVectorShiftScale(double shift, double scale)
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_SetVectorShiftScale_47(base.GetCppThis(), shift, scale);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_TransformVectorsOff_48(HandleRef pThis);

		public virtual void TransformVectorsOff()
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_TransformVectorsOff_48(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkLineIntegralConvolution2D_TransformVectorsOn_49(HandleRef pThis);

		public virtual void TransformVectorsOn()
		{
			vtkLineIntegralConvolution2D.vtkLineIntegralConvolution2D_TransformVectorsOn_49(base.GetCppThis());
		}
	}
}
