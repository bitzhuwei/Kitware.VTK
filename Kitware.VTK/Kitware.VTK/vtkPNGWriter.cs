using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPNGWriter : vtkImageWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPNGWriter";

		public new static readonly string MRClassNameKey;

		static vtkPNGWriter()
		{
			vtkPNGWriter.MRClassNameKey = "class vtkPNGWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPNGWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPNGWriter"));
		}

		public vtkPNGWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPNGWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPNGWriter New()
		{
			vtkPNGWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPNGWriter.vtkPNGWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPNGWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPNGWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPNGWriter.vtkPNGWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPNGWriter_GetResult_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkUnsignedCharArray GetResult()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPNGWriter.vtkPNGWriter_GetResult_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkPNGWriter_GetWriteToMemory_02(HandleRef pThis);

		public virtual uint GetWriteToMemory()
		{
			return vtkPNGWriter.vtkPNGWriter_GetWriteToMemory_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPNGWriter_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPNGWriter.vtkPNGWriter_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPNGWriter_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPNGWriter.vtkPNGWriter_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPNGWriter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPNGWriter NewInstance()
		{
			vtkPNGWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPNGWriter.vtkPNGWriter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPNGWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPNGWriter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPNGWriter SafeDownCast(vtkObjectBase o)
		{
			vtkPNGWriter vtkPNGWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPNGWriter.vtkPNGWriter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPNGWriter = (vtkPNGWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPNGWriter.Register(null);
				}
			}
			return vtkPNGWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPNGWriter_SetResult_08(HandleRef pThis, HandleRef arg0);

		public virtual void SetResult(vtkUnsignedCharArray arg0)
		{
			vtkPNGWriter.vtkPNGWriter_SetResult_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPNGWriter_SetWriteToMemory_09(HandleRef pThis, uint _arg);

		public virtual void SetWriteToMemory(uint _arg)
		{
			vtkPNGWriter.vtkPNGWriter_SetWriteToMemory_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPNGWriter_Write_10(HandleRef pThis);

		public override void Write()
		{
			vtkPNGWriter.vtkPNGWriter_Write_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPNGWriter_WriteToMemoryOff_11(HandleRef pThis);

		public virtual void WriteToMemoryOff()
		{
			vtkPNGWriter.vtkPNGWriter_WriteToMemoryOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPNGWriter_WriteToMemoryOn_12(HandleRef pThis);

		public virtual void WriteToMemoryOn()
		{
			vtkPNGWriter.vtkPNGWriter_WriteToMemoryOn_12(base.GetCppThis());
		}
	}
}
