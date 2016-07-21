using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkXMLStructuredDataWriter : vtkXMLWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLStructuredDataWriter";

		public new static readonly string MRClassNameKey;

		static vtkXMLStructuredDataWriter()
		{
			vtkXMLStructuredDataWriter.MRClassNameKey = "class vtkXMLStructuredDataWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLStructuredDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLStructuredDataWriter"));
		}

		public vtkXMLStructuredDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLStructuredDataWriter_GetExtentTranslator_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkExtentTranslator GetExtentTranslator()
		{
			vtkExtentTranslator vtkExtentTranslator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_GetExtentTranslator_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtentTranslator = (vtkExtentTranslator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtentTranslator.Register(null);
				}
			}
			return vtkExtentTranslator;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLStructuredDataWriter_GetNumberOfPieces_02(HandleRef pThis);

		public virtual int GetNumberOfPieces()
		{
			return vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_GetNumberOfPieces_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLStructuredDataWriter_GetWriteExtent_03(HandleRef pThis);

		public virtual int[] GetWriteExtent()
		{
			IntPtr intPtr = vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_GetWriteExtent_03(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLStructuredDataWriter_GetWriteExtent_04(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetWriteExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_GetWriteExtent_04(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLStructuredDataWriter_GetWriteExtent_05(HandleRef pThis, IntPtr _arg);

		public virtual void GetWriteExtent(IntPtr _arg)
		{
			vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_GetWriteExtent_05(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLStructuredDataWriter_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLStructuredDataWriter_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLStructuredDataWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLStructuredDataWriter NewInstance()
		{
			vtkXMLStructuredDataWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLStructuredDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLStructuredDataWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLStructuredDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLStructuredDataWriter vtkXMLStructuredDataWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLStructuredDataWriter = (vtkXMLStructuredDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLStructuredDataWriter.Register(null);
				}
			}
			return vtkXMLStructuredDataWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLStructuredDataWriter_SetExtentTranslator_10(HandleRef pThis, HandleRef arg0);

		public virtual void SetExtentTranslator(vtkExtentTranslator arg0)
		{
			vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_SetExtentTranslator_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLStructuredDataWriter_SetNumberOfPieces_11(HandleRef pThis, int _arg);

		public virtual void SetNumberOfPieces(int _arg)
		{
			vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_SetNumberOfPieces_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLStructuredDataWriter_SetWriteExtent_12(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetWriteExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_SetWriteExtent_12(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLStructuredDataWriter_SetWriteExtent_13(HandleRef pThis, IntPtr _arg);

		public virtual void SetWriteExtent(IntPtr _arg)
		{
			vtkXMLStructuredDataWriter.vtkXMLStructuredDataWriter_SetWriteExtent_13(base.GetCppThis(), _arg);
		}
	}
}
