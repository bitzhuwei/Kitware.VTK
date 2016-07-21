using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkAbstractPicker : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractPicker";

		public new static readonly string MRClassNameKey;

		static vtkAbstractPicker()
		{
			vtkAbstractPicker.MRClassNameKey = "class vtkAbstractPicker";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractPicker.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractPicker"));
		}

		public vtkAbstractPicker(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractPicker_AddPickList_01(HandleRef pThis, HandleRef arg0);

		public void AddPickList(vtkProp arg0)
		{
			vtkAbstractPicker.vtkAbstractPicker_AddPickList_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractPicker_DeletePickList_02(HandleRef pThis, HandleRef arg0);

		public void DeletePickList(vtkProp arg0)
		{
			vtkAbstractPicker.vtkAbstractPicker_DeletePickList_02(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAbstractPicker_GetPickFromList_03(HandleRef pThis);

		public virtual int GetPickFromList()
		{
			return vtkAbstractPicker.vtkAbstractPicker_GetPickFromList_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractPicker_GetPickList_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPropCollection GetPickList()
		{
			vtkPropCollection vtkPropCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractPicker.vtkAbstractPicker_GetPickList_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPropCollection = (vtkPropCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPropCollection.Register(null);
				}
			}
			return vtkPropCollection;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractPicker_GetPickPosition_05(HandleRef pThis);

		public virtual double[] GetPickPosition()
		{
			IntPtr intPtr = vtkAbstractPicker.vtkAbstractPicker_GetPickPosition_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractPicker_GetPickPosition_06(HandleRef pThis, IntPtr data);

		public virtual void GetPickPosition(IntPtr data)
		{
			vtkAbstractPicker.vtkAbstractPicker_GetPickPosition_06(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractPicker_GetRenderer_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderer GetRenderer()
		{
			vtkRenderer vtkRenderer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractPicker.vtkAbstractPicker_GetRenderer_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderer = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderer.Register(null);
				}
			}
			return vtkRenderer;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractPicker_GetSelectionPoint_08(HandleRef pThis);

		public virtual double[] GetSelectionPoint()
		{
			IntPtr intPtr = vtkAbstractPicker.vtkAbstractPicker_GetSelectionPoint_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractPicker_GetSelectionPoint_09(HandleRef pThis, IntPtr data);

		public virtual void GetSelectionPoint(IntPtr data)
		{
			vtkAbstractPicker.vtkAbstractPicker_GetSelectionPoint_09(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractPicker_InitializePickList_10(HandleRef pThis);

		public void InitializePickList()
		{
			vtkAbstractPicker.vtkAbstractPicker_InitializePickList_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAbstractPicker_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAbstractPicker.vtkAbstractPicker_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAbstractPicker_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAbstractPicker.vtkAbstractPicker_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractPicker_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAbstractPicker NewInstance()
		{
			vtkAbstractPicker result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractPicker.vtkAbstractPicker_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAbstractPicker_Pick_14(HandleRef pThis, double selectionX, double selectionY, double selectionZ, HandleRef renderer);

		public virtual int Pick(double selectionX, double selectionY, double selectionZ, vtkRenderer renderer)
		{
			return vtkAbstractPicker.vtkAbstractPicker_Pick_14(base.GetCppThis(), selectionX, selectionY, selectionZ, (renderer == null) ? default(HandleRef) : renderer.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkAbstractPicker_Pick_15(HandleRef pThis, IntPtr selectionPt, HandleRef ren);

		public int Pick(IntPtr selectionPt, vtkRenderer ren)
		{
			return vtkAbstractPicker.vtkAbstractPicker_Pick_15(base.GetCppThis(), selectionPt, (ren == null) ? default(HandleRef) : ren.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractPicker_PickFromListOff_16(HandleRef pThis);

		public virtual void PickFromListOff()
		{
			vtkAbstractPicker.vtkAbstractPicker_PickFromListOff_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractPicker_PickFromListOn_17(HandleRef pThis);

		public virtual void PickFromListOn()
		{
			vtkAbstractPicker.vtkAbstractPicker_PickFromListOn_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkAbstractPicker_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAbstractPicker SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractPicker vtkAbstractPicker = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAbstractPicker.vtkAbstractPicker_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPicker = (vtkAbstractPicker)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPicker.Register(null);
				}
			}
			return vtkAbstractPicker;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkAbstractPicker_SetPickFromList_19(HandleRef pThis, int _arg);

		public virtual void SetPickFromList(int _arg)
		{
			vtkAbstractPicker.vtkAbstractPicker_SetPickFromList_19(base.GetCppThis(), _arg);
		}
	}
}
