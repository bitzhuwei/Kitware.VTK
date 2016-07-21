using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageCheckerboard : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageCheckerboard";

		public new static readonly string MRClassNameKey;

		static vtkImageCheckerboard()
		{
			vtkImageCheckerboard.MRClassNameKey = "class vtkImageCheckerboard";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageCheckerboard.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageCheckerboard"));
		}

		public vtkImageCheckerboard(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCheckerboard_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageCheckerboard New()
		{
			vtkImageCheckerboard result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageCheckerboard.vtkImageCheckerboard_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCheckerboard)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageCheckerboard() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageCheckerboard.vtkImageCheckerboard_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCheckerboard_GetNumberOfDivisions_01(HandleRef pThis);

		public virtual int[] GetNumberOfDivisions()
		{
			IntPtr intPtr = vtkImageCheckerboard.vtkImageCheckerboard_GetNumberOfDivisions_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCheckerboard_GetNumberOfDivisions_02(HandleRef pThis, IntPtr data);

		public virtual void GetNumberOfDivisions(IntPtr data)
		{
			vtkImageCheckerboard.vtkImageCheckerboard_GetNumberOfDivisions_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageCheckerboard_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageCheckerboard.vtkImageCheckerboard_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageCheckerboard_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageCheckerboard.vtkImageCheckerboard_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCheckerboard_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageCheckerboard NewInstance()
		{
			vtkImageCheckerboard result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageCheckerboard.vtkImageCheckerboard_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageCheckerboard)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageCheckerboard_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageCheckerboard SafeDownCast(vtkObjectBase o)
		{
			vtkImageCheckerboard vtkImageCheckerboard = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageCheckerboard.vtkImageCheckerboard_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageCheckerboard = (vtkImageCheckerboard)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageCheckerboard.Register(null);
				}
			}
			return vtkImageCheckerboard;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCheckerboard_SetInput1_08(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput1(vtkDataObject arg0)
		{
			vtkImageCheckerboard.vtkImageCheckerboard_SetInput1_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCheckerboard_SetInput2_09(HandleRef pThis, HandleRef arg0);

		public virtual void SetInput2(vtkDataObject arg0)
		{
			vtkImageCheckerboard.vtkImageCheckerboard_SetInput2_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCheckerboard_SetNumberOfDivisions_10(HandleRef pThis, int _arg1, int _arg2, int _arg3);

		public virtual void SetNumberOfDivisions(int _arg1, int _arg2, int _arg3)
		{
			vtkImageCheckerboard.vtkImageCheckerboard_SetNumberOfDivisions_10(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageCheckerboard_SetNumberOfDivisions_11(HandleRef pThis, IntPtr _arg);

		public virtual void SetNumberOfDivisions(IntPtr _arg)
		{
			vtkImageCheckerboard.vtkImageCheckerboard_SetNumberOfDivisions_11(base.GetCppThis(), _arg);
		}
	}
}
