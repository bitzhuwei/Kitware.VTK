using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageOpenClose3D : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageOpenClose3D";

		public new static readonly string MRClassNameKey;

		static vtkImageOpenClose3D()
		{
			vtkImageOpenClose3D.MRClassNameKey = "class vtkImageOpenClose3D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageOpenClose3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageOpenClose3D"));
		}

		public vtkImageOpenClose3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageOpenClose3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageOpenClose3D New()
		{
			vtkImageOpenClose3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageOpenClose3D.vtkImageOpenClose3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageOpenClose3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageOpenClose3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageOpenClose3D.vtkImageOpenClose3D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageOpenClose3D_DebugOff_01(HandleRef pThis);

		public override void DebugOff()
		{
			vtkImageOpenClose3D.vtkImageOpenClose3D_DebugOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageOpenClose3D_DebugOn_02(HandleRef pThis);

		public override void DebugOn()
		{
			vtkImageOpenClose3D.vtkImageOpenClose3D_DebugOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageOpenClose3D_GetCloseValue_03(HandleRef pThis);

		public double GetCloseValue()
		{
			return vtkImageOpenClose3D.vtkImageOpenClose3D_GetCloseValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageOpenClose3D_GetFilter0_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageDilateErode3D GetFilter0()
		{
			vtkImageDilateErode3D vtkImageDilateErode3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageOpenClose3D.vtkImageOpenClose3D_GetFilter0_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDilateErode3D = (vtkImageDilateErode3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDilateErode3D.Register(null);
				}
			}
			return vtkImageDilateErode3D;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageOpenClose3D_GetFilter1_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageDilateErode3D GetFilter1()
		{
			vtkImageDilateErode3D vtkImageDilateErode3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageOpenClose3D.vtkImageOpenClose3D_GetFilter1_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDilateErode3D = (vtkImageDilateErode3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDilateErode3D.Register(null);
				}
			}
			return vtkImageDilateErode3D;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern uint vtkImageOpenClose3D_GetMTime_06(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkImageOpenClose3D.vtkImageOpenClose3D_GetMTime_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageOpenClose3D_GetOpenValue_07(HandleRef pThis);

		public double GetOpenValue()
		{
			return vtkImageOpenClose3D.vtkImageOpenClose3D_GetOpenValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageOpenClose3D_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageOpenClose3D.vtkImageOpenClose3D_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageOpenClose3D_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageOpenClose3D.vtkImageOpenClose3D_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageOpenClose3D_Modified_10(HandleRef pThis);

		public override void Modified()
		{
			vtkImageOpenClose3D.vtkImageOpenClose3D_Modified_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageOpenClose3D_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageOpenClose3D NewInstance()
		{
			vtkImageOpenClose3D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageOpenClose3D.vtkImageOpenClose3D_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageOpenClose3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageOpenClose3D_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageOpenClose3D SafeDownCast(vtkObjectBase o)
		{
			vtkImageOpenClose3D vtkImageOpenClose3D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageOpenClose3D.vtkImageOpenClose3D_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageOpenClose3D = (vtkImageOpenClose3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageOpenClose3D.Register(null);
				}
			}
			return vtkImageOpenClose3D;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageOpenClose3D_SetCloseValue_14(HandleRef pThis, double value);

		public void SetCloseValue(double value)
		{
			vtkImageOpenClose3D.vtkImageOpenClose3D_SetCloseValue_14(base.GetCppThis(), value);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageOpenClose3D_SetKernelSize_15(HandleRef pThis, int size0, int size1, int size2);

		public void SetKernelSize(int size0, int size1, int size2)
		{
			vtkImageOpenClose3D.vtkImageOpenClose3D_SetKernelSize_15(base.GetCppThis(), size0, size1, size2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageOpenClose3D_SetOpenValue_16(HandleRef pThis, double value);

		public void SetOpenValue(double value)
		{
			vtkImageOpenClose3D.vtkImageOpenClose3D_SetOpenValue_16(base.GetCppThis(), value);
		}
	}
}
