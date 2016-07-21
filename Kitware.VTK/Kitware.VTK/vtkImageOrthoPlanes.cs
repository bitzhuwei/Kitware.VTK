using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageOrthoPlanes : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageOrthoPlanes";

		public new static readonly string MRClassNameKey;

		static vtkImageOrthoPlanes()
		{
			vtkImageOrthoPlanes.MRClassNameKey = "class vtkImageOrthoPlanes";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageOrthoPlanes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageOrthoPlanes"));
		}

		public vtkImageOrthoPlanes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImageOrthoPlanes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageOrthoPlanes New()
		{
			vtkImageOrthoPlanes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageOrthoPlanes.vtkImageOrthoPlanes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageOrthoPlanes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageOrthoPlanes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageOrthoPlanes.vtkImageOrthoPlanes_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImageOrthoPlanes_GetPlane_01(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImagePlaneWidget GetPlane(int i)
		{
			vtkImagePlaneWidget vtkImagePlaneWidget = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageOrthoPlanes.vtkImageOrthoPlanes_GetPlane_01(base.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImagePlaneWidget = (vtkImagePlaneWidget)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImagePlaneWidget.Register(null);
				}
			}
			return vtkImagePlaneWidget;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImageOrthoPlanes_GetTransform_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkTransform GetTransform()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageOrthoPlanes.vtkImageOrthoPlanes_GetTransform_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageOrthoPlanes_HandlePlaneEvent_03(HandleRef pThis, HandleRef imagePlaneWidget);

		public void HandlePlaneEvent(vtkImagePlaneWidget imagePlaneWidget)
		{
			vtkImageOrthoPlanes.vtkImageOrthoPlanes_HandlePlaneEvent_03(base.GetCppThis(), (imagePlaneWidget == null) ? default(HandleRef) : imagePlaneWidget.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImageOrthoPlanes_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageOrthoPlanes.vtkImageOrthoPlanes_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkImageOrthoPlanes_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageOrthoPlanes.vtkImageOrthoPlanes_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImageOrthoPlanes_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageOrthoPlanes NewInstance()
		{
			vtkImageOrthoPlanes result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageOrthoPlanes.vtkImageOrthoPlanes_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageOrthoPlanes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageOrthoPlanes_ResetPlanes_08(HandleRef pThis);

		public void ResetPlanes()
		{
			vtkImageOrthoPlanes.vtkImageOrthoPlanes_ResetPlanes_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkImageOrthoPlanes_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageOrthoPlanes SafeDownCast(vtkObjectBase o)
		{
			vtkImageOrthoPlanes vtkImageOrthoPlanes = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageOrthoPlanes.vtkImageOrthoPlanes_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageOrthoPlanes = (vtkImageOrthoPlanes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageOrthoPlanes.Register(null);
				}
			}
			return vtkImageOrthoPlanes;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkImageOrthoPlanes_SetPlane_10(HandleRef pThis, int i, HandleRef imagePlaneWidget);

		public void SetPlane(int i, vtkImagePlaneWidget imagePlaneWidget)
		{
			vtkImageOrthoPlanes.vtkImageOrthoPlanes_SetPlane_10(base.GetCppThis(), i, (imagePlaneWidget == null) ? default(HandleRef) : imagePlaneWidget.GetCppThis());
		}
	}
}
