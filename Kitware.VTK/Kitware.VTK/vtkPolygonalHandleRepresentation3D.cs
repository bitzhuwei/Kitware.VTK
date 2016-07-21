using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPolygonalHandleRepresentation3D : vtkAbstractPolygonalHandleRepresentation3D
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolygonalHandleRepresentation3D";

		public new static readonly string MRClassNameKey;

		static vtkPolygonalHandleRepresentation3D()
		{
			vtkPolygonalHandleRepresentation3D.MRClassNameKey = "class vtkPolygonalHandleRepresentation3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolygonalHandleRepresentation3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolygonalHandleRepresentation3D"));
		}

		public vtkPolygonalHandleRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolygonalHandleRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolygonalHandleRepresentation3D New()
		{
			vtkPolygonalHandleRepresentation3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPolygonalHandleRepresentation3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolygonalHandleRepresentation3D_GetOffset_01(HandleRef pThis);

		public virtual double[] GetOffset()
		{
			IntPtr intPtr = vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_GetOffset_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPolygonalHandleRepresentation3D_GetOffset_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetOffset(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_GetOffset_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPolygonalHandleRepresentation3D_GetOffset_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetOffset(IntPtr _arg)
		{
			vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_GetOffset_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolygonalHandleRepresentation3D_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolygonalHandleRepresentation3D_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolygonalHandleRepresentation3D_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolygonalHandleRepresentation3D NewInstance()
		{
			vtkPolygonalHandleRepresentation3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolygonalHandleRepresentation3D_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolygonalHandleRepresentation3D SafeDownCast(vtkObjectBase o)
		{
			vtkPolygonalHandleRepresentation3D vtkPolygonalHandleRepresentation3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolygonalHandleRepresentation3D = (vtkPolygonalHandleRepresentation3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolygonalHandleRepresentation3D.Register(null);
				}
			}
			return vtkPolygonalHandleRepresentation3D;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPolygonalHandleRepresentation3D_SetOffset_09(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOffset(double _arg1, double _arg2, double _arg3)
		{
			vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_SetOffset_09(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPolygonalHandleRepresentation3D_SetOffset_10(HandleRef pThis, IntPtr _arg);

		public virtual void SetOffset(IntPtr _arg)
		{
			vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_SetOffset_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPolygonalHandleRepresentation3D_SetWorldPosition_11(HandleRef pThis, IntPtr p);

		public override void SetWorldPosition(IntPtr p)
		{
			vtkPolygonalHandleRepresentation3D.vtkPolygonalHandleRepresentation3D_SetWorldPosition_11(base.GetCppThis(), p);
		}
	}
}
