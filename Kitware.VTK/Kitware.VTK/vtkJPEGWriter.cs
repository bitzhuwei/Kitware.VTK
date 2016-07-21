using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkJPEGWriter : vtkImageWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkJPEGWriter";

		public new static readonly string MRClassNameKey;

		static vtkJPEGWriter()
		{
			vtkJPEGWriter.MRClassNameKey = "class vtkJPEGWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkJPEGWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkJPEGWriter"));
		}

		public vtkJPEGWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkJPEGWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkJPEGWriter New()
		{
			vtkJPEGWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkJPEGWriter.vtkJPEGWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJPEGWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkJPEGWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkJPEGWriter.vtkJPEGWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkJPEGWriter_GetProgressive_01(HandleRef pThis);

		public virtual uint GetProgressive()
		{
			return vtkJPEGWriter.vtkJPEGWriter_GetProgressive_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkJPEGWriter_GetQuality_02(HandleRef pThis);

		public virtual int GetQuality()
		{
			return vtkJPEGWriter.vtkJPEGWriter_GetQuality_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkJPEGWriter_GetQualityMaxValue_03(HandleRef pThis);

		public virtual int GetQualityMaxValue()
		{
			return vtkJPEGWriter.vtkJPEGWriter_GetQualityMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkJPEGWriter_GetQualityMinValue_04(HandleRef pThis);

		public virtual int GetQualityMinValue()
		{
			return vtkJPEGWriter.vtkJPEGWriter_GetQualityMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkJPEGWriter_GetResult_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkUnsignedCharArray GetResult()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkJPEGWriter.vtkJPEGWriter_GetResult_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkJPEGWriter_GetWriteToMemory_06(HandleRef pThis);

		public virtual uint GetWriteToMemory()
		{
			return vtkJPEGWriter.vtkJPEGWriter_GetWriteToMemory_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkJPEGWriter_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkJPEGWriter.vtkJPEGWriter_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkJPEGWriter_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkJPEGWriter.vtkJPEGWriter_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkJPEGWriter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkJPEGWriter NewInstance()
		{
			vtkJPEGWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkJPEGWriter.vtkJPEGWriter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJPEGWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkJPEGWriter_ProgressiveOff_11(HandleRef pThis);

		public virtual void ProgressiveOff()
		{
			vtkJPEGWriter.vtkJPEGWriter_ProgressiveOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkJPEGWriter_ProgressiveOn_12(HandleRef pThis);

		public virtual void ProgressiveOn()
		{
			vtkJPEGWriter.vtkJPEGWriter_ProgressiveOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkJPEGWriter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkJPEGWriter SafeDownCast(vtkObjectBase o)
		{
			vtkJPEGWriter vtkJPEGWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkJPEGWriter.vtkJPEGWriter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkJPEGWriter = (vtkJPEGWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkJPEGWriter.Register(null);
				}
			}
			return vtkJPEGWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkJPEGWriter_SetProgressive_14(HandleRef pThis, uint _arg);

		public virtual void SetProgressive(uint _arg)
		{
			vtkJPEGWriter.vtkJPEGWriter_SetProgressive_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkJPEGWriter_SetQuality_15(HandleRef pThis, int _arg);

		public virtual void SetQuality(int _arg)
		{
			vtkJPEGWriter.vtkJPEGWriter_SetQuality_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkJPEGWriter_SetResult_16(HandleRef pThis, HandleRef arg0);

		public virtual void SetResult(vtkUnsignedCharArray arg0)
		{
			vtkJPEGWriter.vtkJPEGWriter_SetResult_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkJPEGWriter_SetWriteToMemory_17(HandleRef pThis, uint _arg);

		public virtual void SetWriteToMemory(uint _arg)
		{
			vtkJPEGWriter.vtkJPEGWriter_SetWriteToMemory_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkJPEGWriter_Write_18(HandleRef pThis);

		public override void Write()
		{
			vtkJPEGWriter.vtkJPEGWriter_Write_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkJPEGWriter_WriteToMemoryOff_19(HandleRef pThis);

		public virtual void WriteToMemoryOff()
		{
			vtkJPEGWriter.vtkJPEGWriter_WriteToMemoryOff_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkJPEGWriter_WriteToMemoryOn_20(HandleRef pThis);

		public virtual void WriteToMemoryOn()
		{
			vtkJPEGWriter.vtkJPEGWriter_WriteToMemoryOn_20(base.GetCppThis());
		}
	}
}
