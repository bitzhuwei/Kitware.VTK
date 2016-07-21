using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDistributedStreamTracer : vtkPStreamTracer
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDistributedStreamTracer";

		public new static readonly string MRClassNameKey;

		static vtkDistributedStreamTracer()
		{
			vtkDistributedStreamTracer.MRClassNameKey = "class vtkDistributedStreamTracer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDistributedStreamTracer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistributedStreamTracer"));
		}

		public vtkDistributedStreamTracer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDistributedStreamTracer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDistributedStreamTracer New()
		{
			vtkDistributedStreamTracer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistributedStreamTracer.vtkDistributedStreamTracer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistributedStreamTracer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDistributedStreamTracer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDistributedStreamTracer.vtkDistributedStreamTracer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkDistributedStreamTracer_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDistributedStreamTracer.vtkDistributedStreamTracer_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkDistributedStreamTracer_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDistributedStreamTracer.vtkDistributedStreamTracer_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDistributedStreamTracer_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDistributedStreamTracer NewInstance()
		{
			vtkDistributedStreamTracer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistributedStreamTracer.vtkDistributedStreamTracer_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistributedStreamTracer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDistributedStreamTracer_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDistributedStreamTracer SafeDownCast(vtkObjectBase o)
		{
			vtkDistributedStreamTracer vtkDistributedStreamTracer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDistributedStreamTracer.vtkDistributedStreamTracer_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistributedStreamTracer = (vtkDistributedStreamTracer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistributedStreamTracer.Register(null);
				}
			}
			return vtkDistributedStreamTracer;
		}
	}
}
