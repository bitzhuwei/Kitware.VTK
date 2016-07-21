using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCellPicker : vtkPicker
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellPicker";

		public new static readonly string MRClassNameKey;

		static vtkCellPicker()
		{
			vtkCellPicker.MRClassNameKey = "class vtkCellPicker";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellPicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellPicker"));
		}

		public vtkCellPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellPicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellPicker New()
		{
			vtkCellPicker result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellPicker.vtkCellPicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCellPicker() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCellPicker.vtkCellPicker_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_AddLocator_01(HandleRef pThis, HandleRef locator);

		public void AddLocator(vtkAbstractCellLocator locator)
		{
			vtkCellPicker.vtkCellPicker_AddLocator_01(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellPicker_GetCellIJK_02(HandleRef pThis);

		public virtual int[] GetCellIJK()
		{
			IntPtr intPtr = vtkCellPicker.vtkCellPicker_GetCellIJK_02(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_GetCellIJK_03(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetCellIJK(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkCellPicker.vtkCellPicker_GetCellIJK_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_GetCellIJK_04(HandleRef pThis, IntPtr _arg);

		public virtual void GetCellIJK(IntPtr _arg)
		{
			vtkCellPicker.vtkCellPicker_GetCellIJK_04(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern long vtkCellPicker_GetCellId_05(HandleRef pThis);

		public virtual long GetCellId()
		{
			return vtkCellPicker.vtkCellPicker_GetCellId_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCellPicker_GetClippingPlaneId_06(HandleRef pThis);

		public virtual int GetClippingPlaneId()
		{
			return vtkCellPicker.vtkCellPicker_GetClippingPlaneId_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellPicker_GetMapperNormal_07(HandleRef pThis);

		public virtual double[] GetMapperNormal()
		{
			IntPtr intPtr = vtkCellPicker.vtkCellPicker_GetMapperNormal_07(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_GetMapperNormal_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetMapperNormal(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCellPicker.vtkCellPicker_GetMapperNormal_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_GetMapperNormal_09(HandleRef pThis, IntPtr _arg);

		public virtual void GetMapperNormal(IntPtr _arg)
		{
			vtkCellPicker.vtkCellPicker_GetMapperNormal_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellPicker_GetPCoords_10(HandleRef pThis);

		public virtual double[] GetPCoords()
		{
			IntPtr intPtr = vtkCellPicker.vtkCellPicker_GetPCoords_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_GetPCoords_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetPCoords(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCellPicker.vtkCellPicker_GetPCoords_11(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_GetPCoords_12(HandleRef pThis, IntPtr _arg);

		public virtual void GetPCoords(IntPtr _arg)
		{
			vtkCellPicker.vtkCellPicker_GetPCoords_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCellPicker_GetPickClippingPlanes_13(HandleRef pThis);

		public virtual int GetPickClippingPlanes()
		{
			return vtkCellPicker.vtkCellPicker_GetPickClippingPlanes_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellPicker_GetPickNormal_14(HandleRef pThis);

		public virtual double[] GetPickNormal()
		{
			IntPtr intPtr = vtkCellPicker.vtkCellPicker_GetPickNormal_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_GetPickNormal_15(HandleRef pThis, IntPtr data);

		public virtual void GetPickNormal(IntPtr data)
		{
			vtkCellPicker.vtkCellPicker_GetPickNormal_15(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCellPicker_GetPickTextureData_16(HandleRef pThis);

		public virtual int GetPickTextureData()
		{
			return vtkCellPicker.vtkCellPicker_GetPickTextureData_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellPicker_GetPointIJK_17(HandleRef pThis);

		public virtual int[] GetPointIJK()
		{
			IntPtr intPtr = vtkCellPicker.vtkCellPicker_GetPointIJK_17(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_GetPointIJK_18(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetPointIJK(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkCellPicker.vtkCellPicker_GetPointIJK_18(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_GetPointIJK_19(HandleRef pThis, IntPtr _arg);

		public virtual void GetPointIJK(IntPtr _arg)
		{
			vtkCellPicker.vtkCellPicker_GetPointIJK_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern long vtkCellPicker_GetPointId_20(HandleRef pThis);

		public virtual long GetPointId()
		{
			return vtkCellPicker.vtkCellPicker_GetPointId_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCellPicker_GetSubId_21(HandleRef pThis);

		public virtual int GetSubId()
		{
			return vtkCellPicker.vtkCellPicker_GetSubId_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellPicker_GetTexture_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkTexture GetTexture()
		{
			vtkTexture vtkTexture = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellPicker.vtkCellPicker_GetTexture_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTexture = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTexture.Register(null);
				}
			}
			return vtkTexture;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCellPicker_GetUseVolumeGradientOpacity_23(HandleRef pThis);

		public virtual int GetUseVolumeGradientOpacity()
		{
			return vtkCellPicker.vtkCellPicker_GetUseVolumeGradientOpacity_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkCellPicker_GetVolumeOpacityIsovalue_24(HandleRef pThis);

		public virtual double GetVolumeOpacityIsovalue()
		{
			return vtkCellPicker.vtkCellPicker_GetVolumeOpacityIsovalue_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCellPicker_IsA_25(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCellPicker.vtkCellPicker_IsA_25(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCellPicker_IsTypeOf_26(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCellPicker.vtkCellPicker_IsTypeOf_26(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellPicker_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCellPicker NewInstance()
		{
			vtkCellPicker result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellPicker.vtkCellPicker_NewInstance_28(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCellPicker_Pick_29(HandleRef pThis, double selectionX, double selectionY, double selectionZ, HandleRef renderer);

		public override int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer renderer)
		{
			return vtkCellPicker.vtkCellPicker_Pick_29(base.GetCppThis(), selectionX, selectionY, selectionZ, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_PickClippingPlanesOff_30(HandleRef pThis);

		public virtual void PickClippingPlanesOff()
		{
			vtkCellPicker.vtkCellPicker_PickClippingPlanesOff_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_PickClippingPlanesOn_31(HandleRef pThis);

		public virtual void PickClippingPlanesOn()
		{
			vtkCellPicker.vtkCellPicker_PickClippingPlanesOn_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_PickTextureDataOff_32(HandleRef pThis);

		public virtual void PickTextureDataOff()
		{
			vtkCellPicker.vtkCellPicker_PickTextureDataOff_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_PickTextureDataOn_33(HandleRef pThis);

		public virtual void PickTextureDataOn()
		{
			vtkCellPicker.vtkCellPicker_PickTextureDataOn_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_RemoveAllLocators_34(HandleRef pThis);

		public void RemoveAllLocators()
		{
			vtkCellPicker.vtkCellPicker_RemoveAllLocators_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_RemoveLocator_35(HandleRef pThis, HandleRef locator);

		public void RemoveLocator(vtkAbstractCellLocator locator)
		{
			vtkCellPicker.vtkCellPicker_RemoveLocator_35(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCellPicker_SafeDownCast_36(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellPicker SafeDownCast(vtkObjectBase o)
		{
			vtkCellPicker vtkCellPicker = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellPicker.vtkCellPicker_SafeDownCast_36((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellPicker = (vtkCellPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellPicker.Register(null);
				}
			}
			return vtkCellPicker;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_SetPickClippingPlanes_37(HandleRef pThis, int _arg);

		public virtual void SetPickClippingPlanes(int _arg)
		{
			vtkCellPicker.vtkCellPicker_SetPickClippingPlanes_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_SetPickTextureData_38(HandleRef pThis, int _arg);

		public virtual void SetPickTextureData(int _arg)
		{
			vtkCellPicker.vtkCellPicker_SetPickTextureData_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_SetUseVolumeGradientOpacity_39(HandleRef pThis, int _arg);

		public virtual void SetUseVolumeGradientOpacity(int _arg)
		{
			vtkCellPicker.vtkCellPicker_SetUseVolumeGradientOpacity_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_SetVolumeOpacityIsovalue_40(HandleRef pThis, double _arg);

		public virtual void SetVolumeOpacityIsovalue(double _arg)
		{
			vtkCellPicker.vtkCellPicker_SetVolumeOpacityIsovalue_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_UseVolumeGradientOpacityOff_41(HandleRef pThis);

		public virtual void UseVolumeGradientOpacityOff()
		{
			vtkCellPicker.vtkCellPicker_UseVolumeGradientOpacityOff_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkCellPicker_UseVolumeGradientOpacityOn_42(HandleRef pThis);

		public virtual void UseVolumeGradientOpacityOn()
		{
			vtkCellPicker.vtkCellPicker_UseVolumeGradientOpacityOn_42(base.GetCppThis());
		}
	}
}
