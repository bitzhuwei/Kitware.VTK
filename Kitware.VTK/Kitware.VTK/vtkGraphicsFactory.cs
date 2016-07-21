using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGraphicsFactory : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGraphicsFactory";

		public new static readonly string MRClassNameKey;

		static vtkGraphicsFactory()
		{
			vtkGraphicsFactory.MRClassNameKey = "class vtkGraphicsFactory";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGraphicsFactory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphicsFactory"));
		}

		public vtkGraphicsFactory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphicsFactory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphicsFactory New()
		{
			vtkGraphicsFactory result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphicsFactory.vtkGraphicsFactory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphicsFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGraphicsFactory() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGraphicsFactory.vtkGraphicsFactory_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphicsFactory_CreateInstance_01(string vtkclassname, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkObject CreateInstance(string vtkclassname)
		{
			vtkObject result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphicsFactory.vtkGraphicsFactory_CreateInstance_01(vtkclassname, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGraphicsFactory_GetOffScreenOnlyMode_02();

		public static int GetOffScreenOnlyMode()
		{
			return vtkGraphicsFactory.vtkGraphicsFactory_GetOffScreenOnlyMode_02();
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphicsFactory_GetRenderLibrary_03();

		public static string GetRenderLibrary()
		{
			return Marshal.PtrToStringAnsi(vtkGraphicsFactory.vtkGraphicsFactory_GetRenderLibrary_03());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGraphicsFactory_GetUseMesaClasses_04();

		public static int GetUseMesaClasses()
		{
			return vtkGraphicsFactory.vtkGraphicsFactory_GetUseMesaClasses_04();
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGraphicsFactory_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGraphicsFactory.vtkGraphicsFactory_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkGraphicsFactory_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGraphicsFactory.vtkGraphicsFactory_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphicsFactory_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGraphicsFactory NewInstance()
		{
			vtkGraphicsFactory result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphicsFactory.vtkGraphicsFactory_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGraphicsFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkGraphicsFactory_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGraphicsFactory SafeDownCast(vtkObjectBase o)
		{
			vtkGraphicsFactory vtkGraphicsFactory = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGraphicsFactory.vtkGraphicsFactory_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGraphicsFactory = (vtkGraphicsFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGraphicsFactory.Register(null);
				}
			}
			return vtkGraphicsFactory;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphicsFactory_SetOffScreenOnlyMode_10(int use);

		public static void SetOffScreenOnlyMode(int use)
		{
			vtkGraphicsFactory.vtkGraphicsFactory_SetOffScreenOnlyMode_10(use);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkGraphicsFactory_SetUseMesaClasses_11(int use);

		public static void SetUseMesaClasses(int use)
		{
			vtkGraphicsFactory.vtkGraphicsFactory_SetUseMesaClasses_11(use);
		}
	}
}
