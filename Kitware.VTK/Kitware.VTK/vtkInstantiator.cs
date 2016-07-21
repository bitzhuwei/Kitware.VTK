using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInstantiator : vtkObject
	{
		public delegate IntPtr CreateFunction();

		public new const string MRFullTypeName = "Kitware.VTK.vtkInstantiator";

		public new static readonly string MRClassNameKey;

		static vtkInstantiator()
		{
			vtkInstantiator.MRClassNameKey = "class vtkInstantiator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInstantiator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInstantiator"));
		}

		public vtkInstantiator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInstantiator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInstantiator New()
		{
			vtkInstantiator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInstantiator.vtkInstantiator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInstantiator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInstantiator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInstantiator.vtkInstantiator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInstantiator_CreateInstance_01(string className, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkObject CreateInstance(string className)
		{
			vtkObject result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInstantiator.vtkInstantiator_CreateInstance_01(className, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInstantiator_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInstantiator.vtkInstantiator_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInstantiator_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInstantiator.vtkInstantiator_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInstantiator_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInstantiator NewInstance()
		{
			vtkInstantiator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInstantiator.vtkInstantiator_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInstantiator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInstantiator_RegisterInstantiator_06(string className, vtkInstantiator.CreateFunction createFunction);

		public static void RegisterInstantiator(string className, vtkInstantiator.CreateFunction createFunction)
		{
			vtkInstantiator.vtkInstantiator_RegisterInstantiator_06(className, createFunction);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInstantiator_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInstantiator SafeDownCast(vtkObjectBase o)
		{
			vtkInstantiator vtkInstantiator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInstantiator.vtkInstantiator_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInstantiator = (vtkInstantiator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInstantiator.Register(null);
				}
			}
			return vtkInstantiator;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInstantiator_UnRegisterInstantiator_08(string className, vtkInstantiator.CreateFunction createFunction);

		public static void UnRegisterInstantiator(string className, vtkInstantiator.CreateFunction createFunction)
		{
			vtkInstantiator.vtkInstantiator_UnRegisterInstantiator_08(className, createFunction);
		}
	}
}
