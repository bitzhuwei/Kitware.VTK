using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPImageWriter : vtkImageWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPImageWriter";

		public new static readonly string MRClassNameKey;

		static vtkPImageWriter()
		{
			vtkPImageWriter.MRClassNameKey = "class vtkPImageWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPImageWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPImageWriter"));
		}

		public vtkPImageWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPImageWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPImageWriter New()
		{
			vtkPImageWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPImageWriter.vtkPImageWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPImageWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPImageWriter.vtkPImageWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern uint vtkPImageWriter_GetMemoryLimit_01(HandleRef pThis);

		public virtual uint GetMemoryLimit()
		{
			return vtkPImageWriter.vtkPImageWriter_GetMemoryLimit_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPImageWriter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPImageWriter.vtkPImageWriter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPImageWriter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPImageWriter.vtkPImageWriter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPImageWriter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPImageWriter NewInstance()
		{
			vtkPImageWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPImageWriter.vtkPImageWriter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPImageWriter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPImageWriter SafeDownCast(vtkObjectBase o)
		{
			vtkPImageWriter vtkPImageWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPImageWriter.vtkPImageWriter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPImageWriter = (vtkPImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPImageWriter.Register(null);
				}
			}
			return vtkPImageWriter;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPImageWriter_SetMemoryLimit_07(HandleRef pThis, uint _arg);

		public virtual void SetMemoryLimit(uint _arg)
		{
			vtkPImageWriter.vtkPImageWriter_SetMemoryLimit_07(base.GetCppThis(), _arg);
		}
	}
}
