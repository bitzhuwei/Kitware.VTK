using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageCursor3D : vtkImageInPlaceFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageCursor3D";

		public new static readonly string MRClassNameKey;

		static vtkImageCursor3D()
		{
			vtkImageCursor3D.MRClassNameKey = "class vtkImageCursor3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageCursor3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageCursor3D"));
		}

		public vtkImageCursor3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCursor3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageCursor3D New()
		{
			vtkImageCursor3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageCursor3D.vtkImageCursor3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCursor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageCursor3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageCursor3D.vtkImageCursor3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCursor3D_GetCursorPosition_01(HandleRef pThis);

		public virtual double[] GetCursorPosition()
		{
			IntPtr intPtr = vtkImageCursor3D.vtkImageCursor3D_GetCursorPosition_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCursor3D_GetCursorPosition_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetCursorPosition(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageCursor3D.vtkImageCursor3D_GetCursorPosition_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCursor3D_GetCursorPosition_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetCursorPosition(IntPtr _arg)
		{
			vtkImageCursor3D.vtkImageCursor3D_GetCursorPosition_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageCursor3D_GetCursorRadius_04(HandleRef pThis);

		public virtual int GetCursorRadius()
		{
			return vtkImageCursor3D.vtkImageCursor3D_GetCursorRadius_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageCursor3D_GetCursorValue_05(HandleRef pThis);

		public virtual double GetCursorValue()
		{
			return vtkImageCursor3D.vtkImageCursor3D_GetCursorValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageCursor3D_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageCursor3D.vtkImageCursor3D_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageCursor3D_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageCursor3D.vtkImageCursor3D_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCursor3D_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageCursor3D NewInstance()
		{
			vtkImageCursor3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageCursor3D.vtkImageCursor3D_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCursor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCursor3D_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageCursor3D SafeDownCast(vtkObjectBase o)
		{
			vtkImageCursor3D vtkImageCursor3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageCursor3D.vtkImageCursor3D_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageCursor3D = (vtkImageCursor3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageCursor3D.Register(null);
				}
			}
			return vtkImageCursor3D;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCursor3D_SetCursorPosition_11(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetCursorPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkImageCursor3D.vtkImageCursor3D_SetCursorPosition_11(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCursor3D_SetCursorPosition_12(HandleRef pThis, IntPtr _arg);

		public virtual void SetCursorPosition(IntPtr _arg)
		{
			vtkImageCursor3D.vtkImageCursor3D_SetCursorPosition_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCursor3D_SetCursorRadius_13(HandleRef pThis, int _arg);

		public virtual void SetCursorRadius(int _arg)
		{
			vtkImageCursor3D.vtkImageCursor3D_SetCursorRadius_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCursor3D_SetCursorValue_14(HandleRef pThis, double _arg);

		public virtual void SetCursorValue(double _arg)
		{
			vtkImageCursor3D.vtkImageCursor3D_SetCursorValue_14(base.GetCppThis(), _arg);
		}
	}
}
