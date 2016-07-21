using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImagePermute : vtkImageReslice
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImagePermute";

		public new static readonly string MRClassNameKey;

		static vtkImagePermute()
		{
			vtkImagePermute.MRClassNameKey = "class vtkImagePermute";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImagePermute.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImagePermute"));
		}

		public vtkImagePermute(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePermute_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImagePermute New()
		{
			vtkImagePermute result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePermute.vtkImagePermute_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImagePermute)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImagePermute() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImagePermute.vtkImagePermute_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePermute_GetFilteredAxes_01(HandleRef pThis);

		public virtual int[] GetFilteredAxes()
		{
			IntPtr intPtr = vtkImagePermute.vtkImagePermute_GetFilteredAxes_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImagePermute_GetFilteredAxes_02(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		public virtual void GetFilteredAxes(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImagePermute.vtkImagePermute_GetFilteredAxes_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImagePermute_GetFilteredAxes_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetFilteredAxes(IntPtr _arg)
		{
			vtkImagePermute.vtkImagePermute_GetFilteredAxes_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImagePermute_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImagePermute.vtkImagePermute_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImagePermute_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImagePermute.vtkImagePermute_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePermute_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImagePermute NewInstance()
		{
			vtkImagePermute result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePermute.vtkImagePermute_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImagePermute)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImagePermute_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImagePermute SafeDownCast(vtkObjectBase o)
		{
			vtkImagePermute vtkImagePermute = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagePermute.vtkImagePermute_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImagePermute = (vtkImagePermute)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImagePermute.Register(null);
				}
			}
			return vtkImagePermute;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImagePermute_SetFilteredAxes_09(HandleRef pThis, int x, int y, int z);

		public void SetFilteredAxes(int x, int y, int z)
		{
			vtkImagePermute.vtkImagePermute_SetFilteredAxes_09(base.GetCppThis(), x, y, z);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImagePermute_SetFilteredAxes_10(HandleRef pThis, IntPtr xyz);

		public void SetFilteredAxes(IntPtr xyz)
		{
			vtkImagePermute.vtkImagePermute_SetFilteredAxes_10(base.GetCppThis(), xyz);
		}
	}
}
