using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImagingFactory : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImagingFactory";

		public new static readonly string MRClassNameKey;

		static vtkImagingFactory()
		{
			vtkImagingFactory.MRClassNameKey = "class vtkImagingFactory";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImagingFactory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImagingFactory"));
		}

		public vtkImagingFactory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImagingFactory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImagingFactory New()
		{
			vtkImagingFactory result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagingFactory.vtkImagingFactory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImagingFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImagingFactory() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImagingFactory.vtkImagingFactory_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImagingFactory_CreateInstance_01(string vtkclassname, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public static vtkObject CreateInstance(string vtkclassname)
		{
			vtkObject result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagingFactory.vtkImagingFactory_CreateInstance_01(vtkclassname, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImagingFactory_GetUseMesaClasses_02();

		public static int GetUseMesaClasses()
		{
			return vtkImagingFactory.vtkImagingFactory_GetUseMesaClasses_02();
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImagingFactory_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImagingFactory.vtkImagingFactory_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkImagingFactory_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImagingFactory.vtkImagingFactory_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImagingFactory_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImagingFactory NewInstance()
		{
			vtkImagingFactory result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagingFactory.vtkImagingFactory_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImagingFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkImagingFactory_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImagingFactory SafeDownCast(vtkObjectBase o)
		{
			vtkImagingFactory vtkImagingFactory = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImagingFactory.vtkImagingFactory_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImagingFactory = (vtkImagingFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImagingFactory.Register(null);
				}
			}
			return vtkImagingFactory;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkImagingFactory_SetUseMesaClasses_08(int use);

		public static void SetUseMesaClasses(int use)
		{
			vtkImagingFactory.vtkImagingFactory_SetUseMesaClasses_08(use);
		}
	}
}
