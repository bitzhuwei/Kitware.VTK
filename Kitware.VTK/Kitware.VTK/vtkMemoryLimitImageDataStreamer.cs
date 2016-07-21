using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMemoryLimitImageDataStreamer : vtkImageDataStreamer
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMemoryLimitImageDataStreamer";

		public new static readonly string MRClassNameKey;

		static vtkMemoryLimitImageDataStreamer()
		{
			vtkMemoryLimitImageDataStreamer.MRClassNameKey = "class vtkMemoryLimitImageDataStreamer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMemoryLimitImageDataStreamer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMemoryLimitImageDataStreamer"));
		}

		public vtkMemoryLimitImageDataStreamer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkMemoryLimitImageDataStreamer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMemoryLimitImageDataStreamer New()
		{
			vtkMemoryLimitImageDataStreamer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMemoryLimitImageDataStreamer.vtkMemoryLimitImageDataStreamer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMemoryLimitImageDataStreamer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMemoryLimitImageDataStreamer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMemoryLimitImageDataStreamer.vtkMemoryLimitImageDataStreamer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern uint vtkMemoryLimitImageDataStreamer_GetMemoryLimit_01(HandleRef pThis);

		public virtual uint GetMemoryLimit()
		{
			return vtkMemoryLimitImageDataStreamer.vtkMemoryLimitImageDataStreamer_GetMemoryLimit_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMemoryLimitImageDataStreamer_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMemoryLimitImageDataStreamer.vtkMemoryLimitImageDataStreamer_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkMemoryLimitImageDataStreamer_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMemoryLimitImageDataStreamer.vtkMemoryLimitImageDataStreamer_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkMemoryLimitImageDataStreamer_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMemoryLimitImageDataStreamer NewInstance()
		{
			vtkMemoryLimitImageDataStreamer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMemoryLimitImageDataStreamer.vtkMemoryLimitImageDataStreamer_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMemoryLimitImageDataStreamer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkMemoryLimitImageDataStreamer_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMemoryLimitImageDataStreamer SafeDownCast(vtkObjectBase o)
		{
			vtkMemoryLimitImageDataStreamer vtkMemoryLimitImageDataStreamer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMemoryLimitImageDataStreamer.vtkMemoryLimitImageDataStreamer_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMemoryLimitImageDataStreamer = (vtkMemoryLimitImageDataStreamer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMemoryLimitImageDataStreamer.Register(null);
				}
			}
			return vtkMemoryLimitImageDataStreamer;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkMemoryLimitImageDataStreamer_SetMemoryLimit_07(HandleRef pThis, uint _arg);

		public virtual void SetMemoryLimit(uint _arg)
		{
			vtkMemoryLimitImageDataStreamer.vtkMemoryLimitImageDataStreamer_SetMemoryLimit_07(base.GetCppThis(), _arg);
		}
	}
}
