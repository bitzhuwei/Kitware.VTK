using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageRFFT : vtkImageFourierFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageRFFT";

		public new static readonly string MRClassNameKey;

		static vtkImageRFFT()
		{
			vtkImageRFFT.MRClassNameKey = "class vtkImageRFFT";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageRFFT.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageRFFT"));
		}

		public vtkImageRFFT(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageRFFT_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageRFFT New()
		{
			vtkImageRFFT result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageRFFT.vtkImageRFFT_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRFFT)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageRFFT() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageRFFT.vtkImageRFFT_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageRFFT_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageRFFT.vtkImageRFFT_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageRFFT_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageRFFT.vtkImageRFFT_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageRFFT_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageRFFT NewInstance()
		{
			vtkImageRFFT result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageRFFT.vtkImageRFFT_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRFFT)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageRFFT_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageRFFT SafeDownCast(vtkObjectBase o)
		{
			vtkImageRFFT vtkImageRFFT = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageRFFT.vtkImageRFFT_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageRFFT = (vtkImageRFFT)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageRFFT.Register(null);
				}
			}
			return vtkImageRFFT;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageRFFT_SplitExtent_06(HandleRef pThis, IntPtr splitExt, IntPtr startExt, int num, int total);

		public override int SplitExtent(IntPtr splitExt, IntPtr startExt, int num, int total)
		{
			return vtkImageRFFT.vtkImageRFFT_SplitExtent_06(base.GetCppThis(), splitExt, startExt, num, total);
		}
	}
}
