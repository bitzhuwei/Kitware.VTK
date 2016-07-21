using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStructuredExtent : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredExtent";

		public new static readonly string MRClassNameKey;

		static vtkStructuredExtent()
		{
			vtkStructuredExtent.MRClassNameKey = "class vtkStructuredExtent";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredExtent.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredExtent"));
		}

		public vtkStructuredExtent(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredExtent_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredExtent New()
		{
			vtkStructuredExtent result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredExtent.vtkStructuredExtent_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredExtent)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStructuredExtent() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStructuredExtent.vtkStructuredExtent_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStructuredExtent_Clamp_01(IntPtr ext, IntPtr wholeExt);

		public static void Clamp(IntPtr ext, IntPtr wholeExt)
		{
			vtkStructuredExtent.vtkStructuredExtent_Clamp_01(ext, wholeExt);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStructuredExtent_GetDimensions_02(IntPtr ext, IntPtr dims);

		public static void GetDimensions(IntPtr ext, IntPtr dims)
		{
			vtkStructuredExtent.vtkStructuredExtent_GetDimensions_02(ext, dims);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStructuredExtent_Grow_03(IntPtr ext, int count);

		public static void Grow(IntPtr ext, int count)
		{
			vtkStructuredExtent.vtkStructuredExtent_Grow_03(ext, count);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkStructuredExtent_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStructuredExtent.vtkStructuredExtent_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkStructuredExtent_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStructuredExtent.vtkStructuredExtent_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredExtent_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStructuredExtent NewInstance()
		{
			vtkStructuredExtent result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredExtent.vtkStructuredExtent_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredExtent)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkStructuredExtent_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStructuredExtent SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredExtent vtkStructuredExtent = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStructuredExtent.vtkStructuredExtent_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredExtent = (vtkStructuredExtent)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredExtent.Register(null);
				}
			}
			return vtkStructuredExtent;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkStructuredExtent_Smaller_09(IntPtr ext, IntPtr wholeExt);

		public static bool Smaller(IntPtr ext, IntPtr wholeExt)
		{
			return vtkStructuredExtent.vtkStructuredExtent_Smaller_09(ext, wholeExt) != 0;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern byte vtkStructuredExtent_StrictlySmaller_10(IntPtr ext, IntPtr wholeExt);

		public static bool StrictlySmaller(IntPtr ext, IntPtr wholeExt)
		{
			return vtkStructuredExtent.vtkStructuredExtent_StrictlySmaller_10(ext, wholeExt) != 0;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkStructuredExtent_Transform_11(IntPtr ext, IntPtr wholeExt);

		public static void Transform(IntPtr ext, IntPtr wholeExt)
		{
			vtkStructuredExtent.vtkStructuredExtent_Transform_11(ext, wholeExt);
		}
	}
}
