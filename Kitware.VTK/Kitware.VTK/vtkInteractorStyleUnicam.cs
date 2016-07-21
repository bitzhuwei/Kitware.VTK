using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInteractorStyleUnicam : vtkInteractorStyle
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInteractorStyleUnicam";

		public new static readonly string MRClassNameKey;

		static vtkInteractorStyleUnicam()
		{
			vtkInteractorStyleUnicam.MRClassNameKey = "class vtkInteractorStyleUnicam";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInteractorStyleUnicam.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInteractorStyleUnicam"));
		}

		public vtkInteractorStyleUnicam(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleUnicam_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleUnicam New()
		{
			vtkInteractorStyleUnicam result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleUnicam)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInteractorStyleUnicam() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleUnicam_GetWorldUpVector_01(HandleRef pThis);

		public virtual double[] GetWorldUpVector()
		{
			IntPtr intPtr = vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_GetWorldUpVector_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUnicam_GetWorldUpVector_02(HandleRef pThis, IntPtr data);

		public virtual void GetWorldUpVector(IntPtr data)
		{
			vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_GetWorldUpVector_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleUnicam_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkInteractorStyleUnicam_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleUnicam_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInteractorStyleUnicam NewInstance()
		{
			vtkInteractorStyleUnicam result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInteractorStyleUnicam)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUnicam_OnLeftButtonDown_07(HandleRef pThis);

		public override void OnLeftButtonDown()
		{
			vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_OnLeftButtonDown_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUnicam_OnLeftButtonMove_08(HandleRef pThis);

		public virtual void OnLeftButtonMove()
		{
			vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_OnLeftButtonMove_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUnicam_OnLeftButtonUp_09(HandleRef pThis);

		public override void OnLeftButtonUp()
		{
			vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_OnLeftButtonUp_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUnicam_OnMouseMove_10(HandleRef pThis);

		public override void OnMouseMove()
		{
			vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_OnMouseMove_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUnicam_OnTimer_11(HandleRef pThis);

		public override void OnTimer()
		{
			vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_OnTimer_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkInteractorStyleUnicam_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInteractorStyleUnicam SafeDownCast(vtkObjectBase o)
		{
			vtkInteractorStyleUnicam vtkInteractorStyleUnicam = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInteractorStyleUnicam = (vtkInteractorStyleUnicam)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInteractorStyleUnicam.Register(null);
				}
			}
			return vtkInteractorStyleUnicam;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUnicam_SetWorldUpVector_13(HandleRef pThis, IntPtr a);

		public void SetWorldUpVector(IntPtr a)
		{
			vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_SetWorldUpVector_13(base.GetCppThis(), a);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkInteractorStyleUnicam_SetWorldUpVector_14(HandleRef pThis, double x, double y, double z);

		public void SetWorldUpVector(double x, double y, double z)
		{
			vtkInteractorStyleUnicam.vtkInteractorStyleUnicam_SetWorldUpVector_14(base.GetCppThis(), x, y, z);
		}
	}
}
