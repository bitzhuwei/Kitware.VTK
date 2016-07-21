using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVolumeProperty : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeProperty";

		public new static readonly string MRClassNameKey;

		static vtkVolumeProperty()
		{
			vtkVolumeProperty.MRClassNameKey = "class vtkVolumeProperty";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeProperty.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeProperty"));
		}

		public vtkVolumeProperty(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProperty_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeProperty New()
		{
			vtkVolumeProperty result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVolumeProperty() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVolumeProperty.vtkVolumeProperty_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_DeepCopy_01(HandleRef pThis, HandleRef p);

		public void DeepCopy(vtkVolumeProperty p)
		{
			vtkVolumeProperty.vtkVolumeProperty_DeepCopy_01(base.GetCppThis(), (p == null) ? default(HandleRef) : p.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_DisableGradientOpacityOff_02(HandleRef pThis, int index);

		public virtual void DisableGradientOpacityOff(int index)
		{
			vtkVolumeProperty.vtkVolumeProperty_DisableGradientOpacityOff_02(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_DisableGradientOpacityOff_03(HandleRef pThis);

		public virtual void DisableGradientOpacityOff()
		{
			vtkVolumeProperty.vtkVolumeProperty_DisableGradientOpacityOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_DisableGradientOpacityOn_04(HandleRef pThis, int index);

		public virtual void DisableGradientOpacityOn(int index)
		{
			vtkVolumeProperty.vtkVolumeProperty_DisableGradientOpacityOn_04(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_DisableGradientOpacityOn_05(HandleRef pThis);

		public virtual void DisableGradientOpacityOn()
		{
			vtkVolumeProperty.vtkVolumeProperty_DisableGradientOpacityOn_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeProperty_GetAmbient_06(HandleRef pThis, int index);

		public double GetAmbient(int index)
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetAmbient_06(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeProperty_GetAmbient_07(HandleRef pThis);

		public double GetAmbient()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetAmbient_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProperty_GetColorChannels_08(HandleRef pThis, int index);

		public int GetColorChannels(int index)
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetColorChannels_08(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProperty_GetColorChannels_09(HandleRef pThis);

		public int GetColorChannels()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetColorChannels_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeProperty_GetComponentWeight_10(HandleRef pThis, int index);

		public virtual double GetComponentWeight(int index)
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetComponentWeight_10(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeProperty_GetDiffuse_11(HandleRef pThis, int index);

		public double GetDiffuse(int index)
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetDiffuse_11(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeProperty_GetDiffuse_12(HandleRef pThis);

		public double GetDiffuse()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetDiffuse_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProperty_GetDisableGradientOpacity_13(HandleRef pThis, int index);

		public virtual int GetDisableGradientOpacity(int index)
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetDisableGradientOpacity_13(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProperty_GetDisableGradientOpacity_14(HandleRef pThis);

		public virtual int GetDisableGradientOpacity()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetDisableGradientOpacity_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProperty_GetGradientOpacity_15(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPiecewiseFunction GetGradientOpacity(int index)
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetGradientOpacity_15(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProperty_GetGradientOpacity_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPiecewiseFunction GetGradientOpacity()
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetGradientOpacity_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProperty_GetGrayTransferFunction_17(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPiecewiseFunction GetGrayTransferFunction(int index)
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetGrayTransferFunction_17(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProperty_GetGrayTransferFunction_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPiecewiseFunction GetGrayTransferFunction()
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetGrayTransferFunction_18(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProperty_GetIndependentComponents_19(HandleRef pThis);

		public virtual int GetIndependentComponents()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetIndependentComponents_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProperty_GetIndependentComponentsMaxValue_20(HandleRef pThis);

		public virtual int GetIndependentComponentsMaxValue()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetIndependentComponentsMaxValue_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProperty_GetIndependentComponentsMinValue_21(HandleRef pThis);

		public virtual int GetIndependentComponentsMinValue()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetIndependentComponentsMinValue_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProperty_GetInterpolationType_22(HandleRef pThis);

		public virtual int GetInterpolationType()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetInterpolationType_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProperty_GetInterpolationTypeAsString_23(HandleRef pThis);

		public string GetInterpolationTypeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkVolumeProperty.vtkVolumeProperty_GetInterpolationTypeAsString_23(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProperty_GetInterpolationTypeMaxValue_24(HandleRef pThis);

		public virtual int GetInterpolationTypeMaxValue()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetInterpolationTypeMaxValue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProperty_GetInterpolationTypeMinValue_25(HandleRef pThis);

		public virtual int GetInterpolationTypeMinValue()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetInterpolationTypeMinValue_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkVolumeProperty_GetMTime_26(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetMTime_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProperty_GetRGBTransferFunction_27(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkColorTransferFunction GetRGBTransferFunction(int index)
		{
			vtkColorTransferFunction vtkColorTransferFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetRGBTransferFunction_27(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorTransferFunction = (vtkColorTransferFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorTransferFunction.Register(null);
				}
			}
			return vtkColorTransferFunction;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProperty_GetRGBTransferFunction_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkColorTransferFunction GetRGBTransferFunction()
		{
			vtkColorTransferFunction vtkColorTransferFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetRGBTransferFunction_28(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkColorTransferFunction = (vtkColorTransferFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkColorTransferFunction.Register(null);
				}
			}
			return vtkColorTransferFunction;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProperty_GetScalarOpacity_29(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPiecewiseFunction GetScalarOpacity(int index)
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetScalarOpacity_29(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProperty_GetScalarOpacity_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPiecewiseFunction GetScalarOpacity()
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetScalarOpacity_30(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeProperty_GetScalarOpacityUnitDistance_31(HandleRef pThis, int index);

		public double GetScalarOpacityUnitDistance(int index)
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetScalarOpacityUnitDistance_31(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeProperty_GetScalarOpacityUnitDistance_32(HandleRef pThis);

		public double GetScalarOpacityUnitDistance()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetScalarOpacityUnitDistance_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProperty_GetShade_33(HandleRef pThis, int index);

		public int GetShade(int index)
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetShade_33(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProperty_GetShade_34(HandleRef pThis);

		public int GetShade()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetShade_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeProperty_GetSpecular_35(HandleRef pThis, int index);

		public double GetSpecular(int index)
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetSpecular_35(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeProperty_GetSpecular_36(HandleRef pThis);

		public double GetSpecular()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetSpecular_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeProperty_GetSpecularPower_37(HandleRef pThis, int index);

		public double GetSpecularPower(int index)
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetSpecularPower_37(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkVolumeProperty_GetSpecularPower_38(HandleRef pThis);

		public double GetSpecularPower()
		{
			return vtkVolumeProperty.vtkVolumeProperty_GetSpecularPower_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProperty_GetStoredGradientOpacity_39(HandleRef pThis, int index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPiecewiseFunction GetStoredGradientOpacity(int index)
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetStoredGradientOpacity_39(base.GetCppThis(), index, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProperty_GetStoredGradientOpacity_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPiecewiseFunction GetStoredGradientOpacity()
		{
			vtkPiecewiseFunction vtkPiecewiseFunction = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_GetStoredGradientOpacity_40(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPiecewiseFunction = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPiecewiseFunction.Register(null);
				}
			}
			return vtkPiecewiseFunction;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_IndependentComponentsOff_41(HandleRef pThis);

		public virtual void IndependentComponentsOff()
		{
			vtkVolumeProperty.vtkVolumeProperty_IndependentComponentsOff_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_IndependentComponentsOn_42(HandleRef pThis);

		public virtual void IndependentComponentsOn()
		{
			vtkVolumeProperty.vtkVolumeProperty_IndependentComponentsOn_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProperty_IsA_43(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVolumeProperty.vtkVolumeProperty_IsA_43(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkVolumeProperty_IsTypeOf_44(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVolumeProperty.vtkVolumeProperty_IsTypeOf_44(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProperty_NewInstance_46(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVolumeProperty NewInstance()
		{
			vtkVolumeProperty result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_NewInstance_46(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeProperty_SafeDownCast_47(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeProperty SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeProperty vtkVolumeProperty = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeProperty.vtkVolumeProperty_SafeDownCast_47((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeProperty = (vtkVolumeProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeProperty.Register(null);
				}
			}
			return vtkVolumeProperty;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetAmbient_48(HandleRef pThis, int index, double value);

		public void SetAmbient(int index, double value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetAmbient_48(base.GetCppThis(), index, value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetAmbient_49(HandleRef pThis, double value);

		public void SetAmbient(double value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetAmbient_49(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetColor_50(HandleRef pThis, int index, HandleRef function);

		public void SetColor(int index, vtkPiecewiseFunction function)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetColor_50(base.GetCppThis(), index, (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetColor_51(HandleRef pThis, HandleRef f);

		public void SetColor(vtkPiecewiseFunction f)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetColor_51(base.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetColor_52(HandleRef pThis, int index, HandleRef function);

		public void SetColor(int index, vtkColorTransferFunction function)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetColor_52(base.GetCppThis(), index, (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetColor_53(HandleRef pThis, HandleRef f);

		public void SetColor(vtkColorTransferFunction f)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetColor_53(base.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetComponentWeight_54(HandleRef pThis, int index, double value);

		public virtual void SetComponentWeight(int index, double value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetComponentWeight_54(base.GetCppThis(), index, value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetDiffuse_55(HandleRef pThis, int index, double value);

		public void SetDiffuse(int index, double value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetDiffuse_55(base.GetCppThis(), index, value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetDiffuse_56(HandleRef pThis, double value);

		public void SetDiffuse(double value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetDiffuse_56(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetDisableGradientOpacity_57(HandleRef pThis, int index, int value);

		public virtual void SetDisableGradientOpacity(int index, int value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetDisableGradientOpacity_57(base.GetCppThis(), index, value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetDisableGradientOpacity_58(HandleRef pThis, int value);

		public virtual void SetDisableGradientOpacity(int value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetDisableGradientOpacity_58(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetGradientOpacity_59(HandleRef pThis, int index, HandleRef function);

		public void SetGradientOpacity(int index, vtkPiecewiseFunction function)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetGradientOpacity_59(base.GetCppThis(), index, (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetGradientOpacity_60(HandleRef pThis, HandleRef function);

		public void SetGradientOpacity(vtkPiecewiseFunction function)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetGradientOpacity_60(base.GetCppThis(), (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetIndependentComponents_61(HandleRef pThis, int _arg);

		public virtual void SetIndependentComponents(int _arg)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetIndependentComponents_61(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetInterpolationType_62(HandleRef pThis, int _arg);

		public virtual void SetInterpolationType(int _arg)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetInterpolationType_62(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetInterpolationTypeToLinear_63(HandleRef pThis);

		public void SetInterpolationTypeToLinear()
		{
			vtkVolumeProperty.vtkVolumeProperty_SetInterpolationTypeToLinear_63(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetInterpolationTypeToNearest_64(HandleRef pThis);

		public void SetInterpolationTypeToNearest()
		{
			vtkVolumeProperty.vtkVolumeProperty_SetInterpolationTypeToNearest_64(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetScalarOpacity_65(HandleRef pThis, int index, HandleRef function);

		public void SetScalarOpacity(int index, vtkPiecewiseFunction function)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetScalarOpacity_65(base.GetCppThis(), index, (function == null) ? default(HandleRef) : function.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetScalarOpacity_66(HandleRef pThis, HandleRef f);

		public void SetScalarOpacity(vtkPiecewiseFunction f)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetScalarOpacity_66(base.GetCppThis(), (f == null) ? default(HandleRef) : f.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetScalarOpacityUnitDistance_67(HandleRef pThis, int index, double distance);

		public void SetScalarOpacityUnitDistance(int index, double distance)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetScalarOpacityUnitDistance_67(base.GetCppThis(), index, distance);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetScalarOpacityUnitDistance_68(HandleRef pThis, double distance);

		public void SetScalarOpacityUnitDistance(double distance)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetScalarOpacityUnitDistance_68(base.GetCppThis(), distance);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetShade_69(HandleRef pThis, int index, int value);

		public void SetShade(int index, int value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetShade_69(base.GetCppThis(), index, value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetShade_70(HandleRef pThis, int value);

		public void SetShade(int value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetShade_70(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetSpecular_71(HandleRef pThis, int index, double value);

		public void SetSpecular(int index, double value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetSpecular_71(base.GetCppThis(), index, value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetSpecular_72(HandleRef pThis, double value);

		public void SetSpecular(double value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetSpecular_72(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetSpecularPower_73(HandleRef pThis, int index, double value);

		public void SetSpecularPower(int index, double value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetSpecularPower_73(base.GetCppThis(), index, value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_SetSpecularPower_74(HandleRef pThis, double value);

		public void SetSpecularPower(double value)
		{
			vtkVolumeProperty.vtkVolumeProperty_SetSpecularPower_74(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_ShadeOff_75(HandleRef pThis, int index);

		public void ShadeOff(int index)
		{
			vtkVolumeProperty.vtkVolumeProperty_ShadeOff_75(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_ShadeOff_76(HandleRef pThis);

		public void ShadeOff()
		{
			vtkVolumeProperty.vtkVolumeProperty_ShadeOff_76(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_ShadeOn_77(HandleRef pThis, int index);

		public void ShadeOn(int index)
		{
			vtkVolumeProperty.vtkVolumeProperty_ShadeOn_77(base.GetCppThis(), index);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_ShadeOn_78(HandleRef pThis);

		public void ShadeOn()
		{
			vtkVolumeProperty.vtkVolumeProperty_ShadeOn_78(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkVolumeProperty_UpdateMTimes_79(HandleRef pThis);

		public void UpdateMTimes()
		{
			vtkVolumeProperty.vtkVolumeProperty_UpdateMTimes_79(base.GetCppThis());
		}
	}
}
