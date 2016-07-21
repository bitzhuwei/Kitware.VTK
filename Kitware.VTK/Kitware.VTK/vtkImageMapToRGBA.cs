using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageMapToRGBA : vtkImageMapToColors
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMapToRGBA";

		public new static readonly string MRClassNameKey;

		static vtkImageMapToRGBA()
		{
			vtkImageMapToRGBA.MRClassNameKey = "class vtkImageMapToRGBA";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMapToRGBA.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMapToRGBA"));
		}

		public vtkImageMapToRGBA(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMapToRGBA_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMapToRGBA New()
		{
			vtkImageMapToRGBA result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMapToRGBA.vtkImageMapToRGBA_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMapToRGBA)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageMapToRGBA() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageMapToRGBA.vtkImageMapToRGBA_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMapToRGBA_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageMapToRGBA.vtkImageMapToRGBA_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMapToRGBA_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageMapToRGBA.vtkImageMapToRGBA_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMapToRGBA_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageMapToRGBA NewInstance()
		{
			vtkImageMapToRGBA result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMapToRGBA.vtkImageMapToRGBA_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMapToRGBA)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMapToRGBA_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMapToRGBA SafeDownCast(vtkObjectBase o)
		{
			vtkImageMapToRGBA vtkImageMapToRGBA = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMapToRGBA.vtkImageMapToRGBA_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMapToRGBA = (vtkImageMapToRGBA)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMapToRGBA.Register(null);
				}
			}
			return vtkImageMapToRGBA;
		}
	}
}
