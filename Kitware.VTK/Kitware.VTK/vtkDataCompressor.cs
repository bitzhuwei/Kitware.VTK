using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkDataCompressor : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataCompressor";

		public new static readonly string MRClassNameKey;

		static vtkDataCompressor()
		{
			vtkDataCompressor.MRClassNameKey = "class vtkDataCompressor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataCompressor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataCompressor"));
		}

		public vtkDataCompressor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkDataCompressor_Compress_01(HandleRef pThis, IntPtr uncompressedData, uint uncompressedSize, IntPtr compressedData, uint compressionSpace);

		public uint Compress(IntPtr uncompressedData, uint uncompressedSize, IntPtr compressedData, uint compressionSpace)
		{
			return vtkDataCompressor.vtkDataCompressor_Compress_01(base.GetCppThis(), uncompressedData, uncompressedSize, compressedData, compressionSpace);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataCompressor_Compress_02(HandleRef pThis, IntPtr uncompressedData, uint uncompressedSize, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnsignedCharArray Compress(IntPtr uncompressedData, uint uncompressedSize)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataCompressor.vtkDataCompressor_Compress_02(base.GetCppThis(), uncompressedData, uncompressedSize, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern uint vtkDataCompressor_GetMaximumCompressionSpace_03(HandleRef pThis, uint size);

		public virtual uint GetMaximumCompressionSpace(uint size)
		{
			return vtkDataCompressor.vtkDataCompressor_GetMaximumCompressionSpace_03(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataCompressor_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataCompressor.vtkDataCompressor_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataCompressor_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataCompressor.vtkDataCompressor_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataCompressor_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataCompressor NewInstance()
		{
			vtkDataCompressor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataCompressor.vtkDataCompressor_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataCompressor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataCompressor_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataCompressor SafeDownCast(vtkObjectBase o)
		{
			vtkDataCompressor vtkDataCompressor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataCompressor.vtkDataCompressor_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataCompressor = (vtkDataCompressor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataCompressor.Register(null);
				}
			}
			return vtkDataCompressor;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkDataCompressor_Uncompress_08(HandleRef pThis, IntPtr compressedData, uint compressedSize, IntPtr uncompressedData, uint uncompressedSize);

		public uint Uncompress(IntPtr compressedData, uint compressedSize, IntPtr uncompressedData, uint uncompressedSize)
		{
			return vtkDataCompressor.vtkDataCompressor_Uncompress_08(base.GetCppThis(), compressedData, compressedSize, uncompressedData, uncompressedSize);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataCompressor_Uncompress_09(HandleRef pThis, IntPtr compressedData, uint compressedSize, uint uncompressedSize, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkUnsignedCharArray Uncompress(IntPtr compressedData, uint compressedSize, uint uncompressedSize)
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataCompressor.vtkDataCompressor_Uncompress_09(base.GetCppThis(), compressedData, compressedSize, uncompressedSize, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	}
}
