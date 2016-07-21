using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkCuller : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCuller";

		public new static readonly string MRClassNameKey;

		static vtkCuller()
		{
			vtkCuller.MRClassNameKey = "class vtkCuller";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCuller.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCuller"));
		}

		public vtkCuller(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCuller_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCuller.vtkCuller_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkCuller_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCuller.vtkCuller_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCuller_NewInstance_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCuller NewInstance()
		{
			vtkCuller result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCuller.vtkCuller_NewInstance_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCuller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkCuller_SafeDownCast_04(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCuller SafeDownCast(vtkObjectBase o)
		{
			vtkCuller vtkCuller = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCuller.vtkCuller_SafeDownCast_04((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCuller = (vtkCuller)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCuller.Register(null);
				}
			}
			return vtkCuller;
		}
	}
}
