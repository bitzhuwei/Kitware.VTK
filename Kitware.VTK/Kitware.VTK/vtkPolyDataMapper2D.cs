using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPolyDataMapper2D : vtkMapper2D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataMapper2D";

		public new static readonly string MRClassNameKey;

		static vtkPolyDataMapper2D()
		{
			vtkPolyDataMapper2D.MRClassNameKey = "class vtkPolyDataMapper2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataMapper2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataMapper2D"));
		}

		public vtkPolyDataMapper2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataMapper2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataMapper2D New()
		{
			vtkPolyDataMapper2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataMapper2D.vtkPolyDataMapper2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPolyDataMapper2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPolyDataMapper2D.vtkPolyDataMapper2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_ColorByArrayComponent_01(HandleRef pThis, int arrayNum, int component);

		public void ColorByArrayComponent(int arrayNum, int component)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_ColorByArrayComponent_01(base.GetCppThis(), arrayNum, component);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_ColorByArrayComponent_02(HandleRef pThis, string arrayName, int component);

		public void ColorByArrayComponent(string arrayName, int component)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_ColorByArrayComponent_02(base.GetCppThis(), arrayName, component);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_CreateDefaultLookupTable_03(HandleRef pThis);

		public virtual void CreateDefaultLookupTable()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_CreateDefaultLookupTable_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPolyDataMapper2D_GetArrayAccessMode_04(HandleRef pThis);

		public int GetArrayAccessMode()
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetArrayAccessMode_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPolyDataMapper2D_GetArrayComponent_05(HandleRef pThis);

		public int GetArrayComponent()
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetArrayComponent_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPolyDataMapper2D_GetArrayId_06(HandleRef pThis);

		public int GetArrayId()
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetArrayId_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataMapper2D_GetArrayName_07(HandleRef pThis);

		public string GetArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetArrayName_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPolyDataMapper2D_GetColorMode_08(HandleRef pThis);

		public virtual int GetColorMode()
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetColorMode_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataMapper2D_GetColorModeAsString_09(HandleRef pThis);

		public string GetColorModeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetColorModeAsString_09(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataMapper2D_GetInput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetInput()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetInput_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataMapper2D_GetLookupTable_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkScalarsToColors GetLookupTable()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetLookupTable_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern uint vtkPolyDataMapper2D_GetMTime_12(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetMTime_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPolyDataMapper2D_GetScalarMode_13(HandleRef pThis);

		public virtual int GetScalarMode()
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetScalarMode_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataMapper2D_GetScalarRange_14(HandleRef pThis);

		public virtual double[] GetScalarRange()
		{
			IntPtr intPtr = vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetScalarRange_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_GetScalarRange_15(HandleRef pThis, IntPtr data);

		public virtual void GetScalarRange(IntPtr data)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetScalarRange_15(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPolyDataMapper2D_GetScalarVisibility_16(HandleRef pThis);

		public virtual int GetScalarVisibility()
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetScalarVisibility_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataMapper2D_GetTransformCoordinate_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkCoordinate GetTransformCoordinate()
		{
			vtkCoordinate vtkCoordinate = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetTransformCoordinate_17(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCoordinate = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCoordinate.Register(null);
				}
			}
			return vtkCoordinate;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPolyDataMapper2D_GetUseLookupTableScalarRange_18(HandleRef pThis);

		public virtual int GetUseLookupTableScalarRange()
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_GetUseLookupTableScalarRange_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPolyDataMapper2D_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkPolyDataMapper2D_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataMapper2D.vtkPolyDataMapper2D_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataMapper2D_MapScalars_21(HandleRef pThis, double alpha, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnsignedCharArray MapScalars(double alpha)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataMapper2D.vtkPolyDataMapper2D_MapScalars_21(base.GetCppThis(), alpha, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataMapper2D_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyDataMapper2D NewInstance()
		{
			vtkPolyDataMapper2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataMapper2D.vtkPolyDataMapper2D_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataMapper2D_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataMapper2D SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataMapper2D vtkPolyDataMapper2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataMapper2D.vtkPolyDataMapper2D_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataMapper2D = (vtkPolyDataMapper2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataMapper2D.Register(null);
				}
			}
			return vtkPolyDataMapper2D;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_ScalarVisibilityOff_25(HandleRef pThis);

		public virtual void ScalarVisibilityOff()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_ScalarVisibilityOff_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_ScalarVisibilityOn_26(HandleRef pThis);

		public virtual void ScalarVisibilityOn()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_ScalarVisibilityOn_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_SetColorMode_27(HandleRef pThis, int _arg);

		public virtual void SetColorMode(int _arg)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetColorMode_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_SetColorModeToDefault_28(HandleRef pThis);

		public void SetColorModeToDefault()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetColorModeToDefault_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_SetColorModeToMapScalars_29(HandleRef pThis);

		public void SetColorModeToMapScalars()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetColorModeToMapScalars_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_SetInput_30(HandleRef pThis, HandleRef arg0);

		public void SetInput(vtkPolyData arg0)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetInput_30(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_SetLookupTable_31(HandleRef pThis, HandleRef lut);

		public void SetLookupTable(vtkScalarsToColors lut)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetLookupTable_31(base.GetCppThis(), (lut == null) ? default(HandleRef) : lut.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_SetScalarMode_32(HandleRef pThis, int _arg);

		public virtual void SetScalarMode(int _arg)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetScalarMode_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_SetScalarModeToDefault_33(HandleRef pThis);

		public void SetScalarModeToDefault()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetScalarModeToDefault_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_SetScalarModeToUseCellData_34(HandleRef pThis);

		public void SetScalarModeToUseCellData()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetScalarModeToUseCellData_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_SetScalarModeToUseCellFieldData_35(HandleRef pThis);

		public void SetScalarModeToUseCellFieldData()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetScalarModeToUseCellFieldData_35(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_SetScalarModeToUsePointData_36(HandleRef pThis);

		public void SetScalarModeToUsePointData()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetScalarModeToUsePointData_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_SetScalarModeToUsePointFieldData_37(HandleRef pThis);

		public void SetScalarModeToUsePointFieldData()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetScalarModeToUsePointFieldData_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_SetScalarRange_38(HandleRef pThis, double _arg1, double _arg2);

		public virtual void SetScalarRange(double _arg1, double _arg2)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetScalarRange_38(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_SetScalarRange_39(HandleRef pThis, IntPtr _arg);

		public void SetScalarRange(IntPtr _arg)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetScalarRange_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_SetScalarVisibility_40(HandleRef pThis, int _arg);

		public virtual void SetScalarVisibility(int _arg)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetScalarVisibility_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_SetTransformCoordinate_41(HandleRef pThis, HandleRef arg0);

		public virtual void SetTransformCoordinate(vtkCoordinate arg0)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetTransformCoordinate_41(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_SetUseLookupTableScalarRange_42(HandleRef pThis, int _arg);

		public virtual void SetUseLookupTableScalarRange(int _arg)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_SetUseLookupTableScalarRange_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_ShallowCopy_43(HandleRef pThis, HandleRef m);

		public new void ShallowCopy(vtkAbstractMapper m)
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_ShallowCopy_43(base.GetCppThis(), (m == null) ? default(HandleRef) : m.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_UseLookupTableScalarRangeOff_44(HandleRef pThis);

		public virtual void UseLookupTableScalarRangeOff()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_UseLookupTableScalarRangeOff_44(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkPolyDataMapper2D_UseLookupTableScalarRangeOn_45(HandleRef pThis);

		public virtual void UseLookupTableScalarRangeOn()
		{
			vtkPolyDataMapper2D.vtkPolyDataMapper2D_UseLookupTableScalarRangeOn_45(base.GetCppThis());
		}
	}
}
