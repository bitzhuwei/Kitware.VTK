using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTIFFWriter : vtkImageWriter
	{
		public enum Deflate_WrapperEnum
		{
			Deflate = 3,
			JPEG = 2,
			LZW = 4,
			NoCompression = 0,
			PackBits
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkTIFFWriter";

		public new static readonly string MRClassNameKey;

		static vtkTIFFWriter()
		{
			vtkTIFFWriter.MRClassNameKey = "class vtkTIFFWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTIFFWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTIFFWriter"));
		}

		public vtkTIFFWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTIFFWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTIFFWriter New()
		{
			vtkTIFFWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTIFFWriter.vtkTIFFWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTIFFWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTIFFWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTIFFWriter.vtkTIFFWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTIFFWriter_GetCompression_01(HandleRef pThis);

		public virtual int GetCompression()
		{
			return vtkTIFFWriter.vtkTIFFWriter_GetCompression_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTIFFWriter_GetCompressionMaxValue_02(HandleRef pThis);

		public virtual int GetCompressionMaxValue()
		{
			return vtkTIFFWriter.vtkTIFFWriter_GetCompressionMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTIFFWriter_GetCompressionMinValue_03(HandleRef pThis);

		public virtual int GetCompressionMinValue()
		{
			return vtkTIFFWriter.vtkTIFFWriter_GetCompressionMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTIFFWriter_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTIFFWriter.vtkTIFFWriter_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkTIFFWriter_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTIFFWriter.vtkTIFFWriter_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTIFFWriter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTIFFWriter NewInstance()
		{
			vtkTIFFWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTIFFWriter.vtkTIFFWriter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTIFFWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkTIFFWriter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTIFFWriter SafeDownCast(vtkObjectBase o)
		{
			vtkTIFFWriter vtkTIFFWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTIFFWriter.vtkTIFFWriter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTIFFWriter = (vtkTIFFWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTIFFWriter.Register(null);
				}
			}
			return vtkTIFFWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTIFFWriter_SetCompression_09(HandleRef pThis, int _arg);

		public virtual void SetCompression(int _arg)
		{
			vtkTIFFWriter.vtkTIFFWriter_SetCompression_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTIFFWriter_SetCompressionToDeflate_10(HandleRef pThis);

		public void SetCompressionToDeflate()
		{
			vtkTIFFWriter.vtkTIFFWriter_SetCompressionToDeflate_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTIFFWriter_SetCompressionToJPEG_11(HandleRef pThis);

		public void SetCompressionToJPEG()
		{
			vtkTIFFWriter.vtkTIFFWriter_SetCompressionToJPEG_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTIFFWriter_SetCompressionToLZW_12(HandleRef pThis);

		public void SetCompressionToLZW()
		{
			vtkTIFFWriter.vtkTIFFWriter_SetCompressionToLZW_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTIFFWriter_SetCompressionToNoCompression_13(HandleRef pThis);

		public void SetCompressionToNoCompression()
		{
			vtkTIFFWriter.vtkTIFFWriter_SetCompressionToNoCompression_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkTIFFWriter_SetCompressionToPackBits_14(HandleRef pThis);

		public void SetCompressionToPackBits()
		{
			vtkTIFFWriter.vtkTIFFWriter_SetCompressionToPackBits_14(base.GetCppThis());
		}
	}
}
