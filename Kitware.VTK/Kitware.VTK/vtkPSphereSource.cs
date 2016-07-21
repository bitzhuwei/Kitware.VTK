using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPSphereSource : vtkSphereSource
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPSphereSource";

		public new static readonly string MRClassNameKey;

		static vtkPSphereSource()
		{
			vtkPSphereSource.MRClassNameKey = "class vtkPSphereSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPSphereSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPSphereSource"));
		}

		public vtkPSphereSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPSphereSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPSphereSource New()
		{
			vtkPSphereSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPSphereSource.vtkPSphereSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPSphereSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPSphereSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPSphereSource.vtkPSphereSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern uint vtkPSphereSource_GetEstimatedMemorySize_01(HandleRef pThis);

		public uint GetEstimatedMemorySize()
		{
			return vtkPSphereSource.vtkPSphereSource_GetEstimatedMemorySize_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPSphereSource_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPSphereSource.vtkPSphereSource_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPSphereSource_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPSphereSource.vtkPSphereSource_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPSphereSource_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPSphereSource NewInstance()
		{
			vtkPSphereSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPSphereSource.vtkPSphereSource_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPSphereSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPSphereSource_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPSphereSource SafeDownCast(vtkObjectBase o)
		{
			vtkPSphereSource vtkPSphereSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPSphereSource.vtkPSphereSource_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPSphereSource = (vtkPSphereSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPSphereSource.Register(null);
				}
			}
			return vtkPSphereSource;
		}
	}
}
