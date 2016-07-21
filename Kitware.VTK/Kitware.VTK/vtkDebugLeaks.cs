using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDebugLeaks : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDebugLeaks";

		public new static readonly string MRClassNameKey;

		static vtkDebugLeaks()
		{
			vtkDebugLeaks.MRClassNameKey = "class vtkDebugLeaks";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDebugLeaks.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDebugLeaks"));
		}

		public vtkDebugLeaks(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDebugLeaks_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDebugLeaks New()
		{
			vtkDebugLeaks result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDebugLeaks.vtkDebugLeaks_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDebugLeaks)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDebugLeaks() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDebugLeaks.vtkDebugLeaks_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDebugLeaks_ConstructClass_01(string classname);

		public static void ConstructClass(string classname)
		{
			vtkDebugLeaks.vtkDebugLeaks_ConstructClass_01(classname);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDebugLeaks_DestructClass_02(string classname);

		public static void DestructClass(string classname)
		{
			vtkDebugLeaks.vtkDebugLeaks_DestructClass_02(classname);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDebugLeaks_GetExitError_03();

		public static int GetExitError()
		{
			return vtkDebugLeaks.vtkDebugLeaks_GetExitError_03();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDebugLeaks_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDebugLeaks.vtkDebugLeaks_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDebugLeaks_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDebugLeaks.vtkDebugLeaks_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDebugLeaks_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDebugLeaks NewInstance()
		{
			vtkDebugLeaks result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDebugLeaks.vtkDebugLeaks_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDebugLeaks)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkDebugLeaks_PrintCurrentLeaks_08();

		public static int PrintCurrentLeaks()
		{
			return vtkDebugLeaks.vtkDebugLeaks_PrintCurrentLeaks_08();
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkDebugLeaks_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDebugLeaks SafeDownCast(vtkObjectBase o)
		{
			vtkDebugLeaks vtkDebugLeaks = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDebugLeaks.vtkDebugLeaks_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDebugLeaks = (vtkDebugLeaks)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDebugLeaks.Register(null);
				}
			}
			return vtkDebugLeaks;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkDebugLeaks_SetExitError_10(int arg0);

		public static void SetExitError(int arg0)
		{
			vtkDebugLeaks.vtkDebugLeaks_SetExitError_10(arg0);
		}
	}
}
