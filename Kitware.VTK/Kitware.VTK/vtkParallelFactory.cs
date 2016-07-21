using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkParallelFactory : vtkObjectFactory
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkParallelFactory";

		public new static readonly string MRClassNameKey;

		static vtkParallelFactory()
		{
			vtkParallelFactory.MRClassNameKey = "class vtkParallelFactory";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParallelFactory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParallelFactory"));
		}

		public vtkParallelFactory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelFactory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParallelFactory New()
		{
			vtkParallelFactory result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelFactory.vtkParallelFactory_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkParallelFactory() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkParallelFactory.vtkParallelFactory_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelFactory_GetDescription_01(HandleRef pThis);

		public override string GetDescription()
		{
			return Marshal.PtrToStringAnsi(vtkParallelFactory.vtkParallelFactory_GetDescription_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelFactory_GetVTKSourceVersion_02(HandleRef pThis);

		public override string GetVTKSourceVersion()
		{
			return Marshal.PtrToStringAnsi(vtkParallelFactory.vtkParallelFactory_GetVTKSourceVersion_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkParallelFactory_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkParallelFactory.vtkParallelFactory_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkParallelFactory_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkParallelFactory.vtkParallelFactory_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelFactory_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkParallelFactory NewInstance()
		{
			vtkParallelFactory result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelFactory.vtkParallelFactory_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParallelFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkParallelFactory_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkParallelFactory SafeDownCast(vtkObjectBase o)
		{
			vtkParallelFactory vtkParallelFactory = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkParallelFactory.vtkParallelFactory_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParallelFactory = (vtkParallelFactory)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParallelFactory.Register(null);
				}
			}
			return vtkParallelFactory;
		}
	}
}
