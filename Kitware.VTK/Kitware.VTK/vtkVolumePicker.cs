using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVolumePicker : vtkCellPicker
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumePicker";

		public new static readonly string MRClassNameKey;

		static vtkVolumePicker()
		{
			vtkVolumePicker.MRClassNameKey = "class vtkVolumePicker";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumePicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumePicker"));
		}

		public vtkVolumePicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumePicker_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumePicker New()
		{
			vtkVolumePicker result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumePicker.vtkVolumePicker_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumePicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVolumePicker() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVolumePicker.vtkVolumePicker_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumePicker_GetCroppingPlaneId_01(HandleRef pThis);

		public virtual int GetCroppingPlaneId()
		{
			return vtkVolumePicker.vtkVolumePicker_GetCroppingPlaneId_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumePicker_GetPickCroppingPlanes_02(HandleRef pThis);

		public virtual int GetPickCroppingPlanes()
		{
			return vtkVolumePicker.vtkVolumePicker_GetPickCroppingPlanes_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumePicker_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVolumePicker.vtkVolumePicker_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern int vtkVolumePicker_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVolumePicker.vtkVolumePicker_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumePicker_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVolumePicker NewInstance()
		{
			vtkVolumePicker result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumePicker.vtkVolumePicker_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumePicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumePicker_PickCroppingPlanesOff_07(HandleRef pThis);

		public virtual void PickCroppingPlanesOff()
		{
			vtkVolumePicker.vtkVolumePicker_PickCroppingPlanesOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumePicker_PickCroppingPlanesOn_08(HandleRef pThis);

		public virtual void PickCroppingPlanesOn()
		{
			vtkVolumePicker.vtkVolumePicker_PickCroppingPlanesOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumePicker_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumePicker SafeDownCast(vtkObjectBase o)
		{
			vtkVolumePicker vtkVolumePicker = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumePicker.vtkVolumePicker_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumePicker = (vtkVolumePicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumePicker.Register(null);
				}
			}
			return vtkVolumePicker;
		}

		[DllImport("Kitware.VTK.vtkVolumeRendering.Unmanaged.dll")]
		internal static extern void vtkVolumePicker_SetPickCroppingPlanes_10(HandleRef pThis, int _arg);

		public virtual void SetPickCroppingPlanes(int _arg)
		{
			vtkVolumePicker.vtkVolumePicker_SetPickCroppingPlanes_10(base.GetCppThis(), _arg);
		}
	}
}
