using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageFFT : vtkImageFourierFilter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageFFT";

		public new static readonly string MRClassNameKey;

		static vtkImageFFT()
		{
			vtkImageFFT.MRClassNameKey = "class vtkImageFFT";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageFFT.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageFFT"));
		}

		public vtkImageFFT(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageFFT_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageFFT New()
		{
			vtkImageFFT result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageFFT.vtkImageFFT_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageFFT)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageFFT() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageFFT.vtkImageFFT_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageFFT_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageFFT.vtkImageFFT_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageFFT_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageFFT.vtkImageFFT_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageFFT_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageFFT NewInstance()
		{
			vtkImageFFT result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageFFT.vtkImageFFT_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageFFT)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageFFT_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageFFT SafeDownCast(vtkObjectBase o)
		{
			vtkImageFFT vtkImageFFT = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageFFT.vtkImageFFT_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageFFT = (vtkImageFFT)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageFFT.Register(null);
				}
			}
			return vtkImageFFT;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageFFT_SplitExtent_06(HandleRef pThis, IntPtr splitExt, IntPtr startExt, int num, int total);

		public override int SplitExtent(IntPtr splitExt, IntPtr startExt, int num, int total)
		{
			return vtkImageFFT.vtkImageFFT_SplitExtent_06(base.GetCppThis(), splitExt, startExt, num, total);
		}
	}
}
