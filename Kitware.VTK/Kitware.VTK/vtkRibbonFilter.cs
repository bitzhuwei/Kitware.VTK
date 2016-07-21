using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkRibbonFilter : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkRibbonFilter";

		public new static readonly string MRClassNameKey;

		static vtkRibbonFilter()
		{
			vtkRibbonFilter.MRClassNameKey = "class vtkRibbonFilter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRibbonFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRibbonFilter"));
		}

		public vtkRibbonFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRibbonFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRibbonFilter New()
		{
			vtkRibbonFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRibbonFilter.vtkRibbonFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRibbonFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkRibbonFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkRibbonFilter.vtkRibbonFilter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRibbonFilter_GetAngle_01(HandleRef pThis);

		public virtual double GetAngle()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetAngle_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRibbonFilter_GetAngleMaxValue_02(HandleRef pThis);

		public virtual double GetAngleMaxValue()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetAngleMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRibbonFilter_GetAngleMinValue_03(HandleRef pThis);

		public virtual double GetAngleMinValue()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetAngleMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRibbonFilter_GetDefaultNormal_04(HandleRef pThis);

		public virtual double[] GetDefaultNormal()
		{
			IntPtr intPtr = vtkRibbonFilter.vtkRibbonFilter_GetDefaultNormal_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRibbonFilter_GetDefaultNormal_05(HandleRef pThis, IntPtr data);

		public virtual void GetDefaultNormal(IntPtr data)
		{
			vtkRibbonFilter.vtkRibbonFilter_GetDefaultNormal_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRibbonFilter_GetGenerateTCoords_06(HandleRef pThis);

		public virtual int GetGenerateTCoords()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetGenerateTCoords_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRibbonFilter_GetGenerateTCoordsAsString_07(HandleRef pThis);

		public string GetGenerateTCoordsAsString()
		{
			return Marshal.PtrToStringAnsi(vtkRibbonFilter.vtkRibbonFilter_GetGenerateTCoordsAsString_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRibbonFilter_GetGenerateTCoordsMaxValue_08(HandleRef pThis);

		public virtual int GetGenerateTCoordsMaxValue()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetGenerateTCoordsMaxValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRibbonFilter_GetGenerateTCoordsMinValue_09(HandleRef pThis);

		public virtual int GetGenerateTCoordsMinValue()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetGenerateTCoordsMinValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRibbonFilter_GetTextureLength_10(HandleRef pThis);

		public virtual double GetTextureLength()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetTextureLength_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRibbonFilter_GetTextureLengthMaxValue_11(HandleRef pThis);

		public virtual double GetTextureLengthMaxValue()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetTextureLengthMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRibbonFilter_GetTextureLengthMinValue_12(HandleRef pThis);

		public virtual double GetTextureLengthMinValue()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetTextureLengthMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRibbonFilter_GetUseDefaultNormal_13(HandleRef pThis);

		public virtual int GetUseDefaultNormal()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetUseDefaultNormal_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRibbonFilter_GetVaryWidth_14(HandleRef pThis);

		public virtual int GetVaryWidth()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetVaryWidth_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRibbonFilter_GetWidth_15(HandleRef pThis);

		public virtual double GetWidth()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetWidth_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRibbonFilter_GetWidthFactor_16(HandleRef pThis);

		public virtual double GetWidthFactor()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetWidthFactor_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRibbonFilter_GetWidthMaxValue_17(HandleRef pThis);

		public virtual double GetWidthMaxValue()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetWidthMaxValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkRibbonFilter_GetWidthMinValue_18(HandleRef pThis);

		public virtual double GetWidthMinValue()
		{
			return vtkRibbonFilter.vtkRibbonFilter_GetWidthMinValue_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRibbonFilter_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkRibbonFilter.vtkRibbonFilter_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkRibbonFilter_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkRibbonFilter.vtkRibbonFilter_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRibbonFilter_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkRibbonFilter NewInstance()
		{
			vtkRibbonFilter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRibbonFilter.vtkRibbonFilter_NewInstance_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRibbonFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkRibbonFilter_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkRibbonFilter SafeDownCast(vtkObjectBase o)
		{
			vtkRibbonFilter vtkRibbonFilter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkRibbonFilter.vtkRibbonFilter_SafeDownCast_23((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRibbonFilter = (vtkRibbonFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRibbonFilter.Register(null);
				}
			}
			return vtkRibbonFilter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRibbonFilter_SetAngle_24(HandleRef pThis, double _arg);

		public virtual void SetAngle(double _arg)
		{
			vtkRibbonFilter.vtkRibbonFilter_SetAngle_24(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRibbonFilter_SetDefaultNormal_25(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetDefaultNormal(double _arg1, double _arg2, double _arg3)
		{
			vtkRibbonFilter.vtkRibbonFilter_SetDefaultNormal_25(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRibbonFilter_SetDefaultNormal_26(HandleRef pThis, IntPtr _arg);

		public virtual void SetDefaultNormal(IntPtr _arg)
		{
			vtkRibbonFilter.vtkRibbonFilter_SetDefaultNormal_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRibbonFilter_SetGenerateTCoords_27(HandleRef pThis, int _arg);

		public virtual void SetGenerateTCoords(int _arg)
		{
			vtkRibbonFilter.vtkRibbonFilter_SetGenerateTCoords_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRibbonFilter_SetGenerateTCoordsToNormalizedLength_28(HandleRef pThis);

		public void SetGenerateTCoordsToNormalizedLength()
		{
			vtkRibbonFilter.vtkRibbonFilter_SetGenerateTCoordsToNormalizedLength_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRibbonFilter_SetGenerateTCoordsToOff_29(HandleRef pThis);

		public void SetGenerateTCoordsToOff()
		{
			vtkRibbonFilter.vtkRibbonFilter_SetGenerateTCoordsToOff_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRibbonFilter_SetGenerateTCoordsToUseLength_30(HandleRef pThis);

		public void SetGenerateTCoordsToUseLength()
		{
			vtkRibbonFilter.vtkRibbonFilter_SetGenerateTCoordsToUseLength_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRibbonFilter_SetGenerateTCoordsToUseScalars_31(HandleRef pThis);

		public void SetGenerateTCoordsToUseScalars()
		{
			vtkRibbonFilter.vtkRibbonFilter_SetGenerateTCoordsToUseScalars_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRibbonFilter_SetTextureLength_32(HandleRef pThis, double _arg);

		public virtual void SetTextureLength(double _arg)
		{
			vtkRibbonFilter.vtkRibbonFilter_SetTextureLength_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRibbonFilter_SetUseDefaultNormal_33(HandleRef pThis, int _arg);

		public virtual void SetUseDefaultNormal(int _arg)
		{
			vtkRibbonFilter.vtkRibbonFilter_SetUseDefaultNormal_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRibbonFilter_SetVaryWidth_34(HandleRef pThis, int _arg);

		public virtual void SetVaryWidth(int _arg)
		{
			vtkRibbonFilter.vtkRibbonFilter_SetVaryWidth_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRibbonFilter_SetWidth_35(HandleRef pThis, double _arg);

		public virtual void SetWidth(double _arg)
		{
			vtkRibbonFilter.vtkRibbonFilter_SetWidth_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRibbonFilter_SetWidthFactor_36(HandleRef pThis, double _arg);

		public virtual void SetWidthFactor(double _arg)
		{
			vtkRibbonFilter.vtkRibbonFilter_SetWidthFactor_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRibbonFilter_UseDefaultNormalOff_37(HandleRef pThis);

		public virtual void UseDefaultNormalOff()
		{
			vtkRibbonFilter.vtkRibbonFilter_UseDefaultNormalOff_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRibbonFilter_UseDefaultNormalOn_38(HandleRef pThis);

		public virtual void UseDefaultNormalOn()
		{
			vtkRibbonFilter.vtkRibbonFilter_UseDefaultNormalOn_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRibbonFilter_VaryWidthOff_39(HandleRef pThis);

		public virtual void VaryWidthOff()
		{
			vtkRibbonFilter.vtkRibbonFilter_VaryWidthOff_39(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkRibbonFilter_VaryWidthOn_40(HandleRef pThis);

		public virtual void VaryWidthOn()
		{
			vtkRibbonFilter.vtkRibbonFilter_VaryWidthOn_40(base.GetCppThis());
		}
	}
}
