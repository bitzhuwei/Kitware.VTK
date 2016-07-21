using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkXMLPDataWriter : vtkXMLWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPDataWriter";

		public new static readonly string MRClassNameKey;

		static vtkXMLPDataWriter()
		{
			vtkXMLPDataWriter.MRClassNameKey = "class vtkXMLPDataWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPDataWriter"));
		}

		public vtkXMLPDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPDataWriter_GetEndPiece_01(HandleRef pThis);

		public virtual int GetEndPiece()
		{
			return vtkXMLPDataWriter.vtkXMLPDataWriter_GetEndPiece_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPDataWriter_GetGhostLevel_02(HandleRef pThis);

		public virtual int GetGhostLevel()
		{
			return vtkXMLPDataWriter.vtkXMLPDataWriter_GetGhostLevel_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPDataWriter_GetNumberOfPieces_03(HandleRef pThis);

		public virtual int GetNumberOfPieces()
		{
			return vtkXMLPDataWriter.vtkXMLPDataWriter_GetNumberOfPieces_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPDataWriter_GetStartPiece_04(HandleRef pThis);

		public virtual int GetStartPiece()
		{
			return vtkXMLPDataWriter.vtkXMLPDataWriter_GetStartPiece_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPDataWriter_GetWriteSummaryFile_05(HandleRef pThis);

		public virtual int GetWriteSummaryFile()
		{
			return vtkXMLPDataWriter.vtkXMLPDataWriter_GetWriteSummaryFile_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPDataWriter_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLPDataWriter.vtkXMLPDataWriter_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPDataWriter_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLPDataWriter.vtkXMLPDataWriter_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPDataWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLPDataWriter NewInstance()
		{
			vtkXMLPDataWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPDataWriter.vtkXMLPDataWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPDataWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLPDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPDataWriter vtkXMLPDataWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPDataWriter.vtkXMLPDataWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPDataWriter = (vtkXMLPDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPDataWriter.Register(null);
				}
			}
			return vtkXMLPDataWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLPDataWriter_SetEndPiece_10(HandleRef pThis, int _arg);

		public virtual void SetEndPiece(int _arg)
		{
			vtkXMLPDataWriter.vtkXMLPDataWriter_SetEndPiece_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLPDataWriter_SetGhostLevel_11(HandleRef pThis, int _arg);

		public virtual void SetGhostLevel(int _arg)
		{
			vtkXMLPDataWriter.vtkXMLPDataWriter_SetGhostLevel_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLPDataWriter_SetNumberOfPieces_12(HandleRef pThis, int _arg);

		public virtual void SetNumberOfPieces(int _arg)
		{
			vtkXMLPDataWriter.vtkXMLPDataWriter_SetNumberOfPieces_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLPDataWriter_SetStartPiece_13(HandleRef pThis, int _arg);

		public virtual void SetStartPiece(int _arg)
		{
			vtkXMLPDataWriter.vtkXMLPDataWriter_SetStartPiece_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLPDataWriter_SetWriteSummaryFile_14(HandleRef pThis, int flag);

		public virtual void SetWriteSummaryFile(int flag)
		{
			vtkXMLPDataWriter.vtkXMLPDataWriter_SetWriteSummaryFile_14(base.GetCppThis(), flag);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLPDataWriter_WriteSummaryFileOff_15(HandleRef pThis);

		public virtual void WriteSummaryFileOff()
		{
			vtkXMLPDataWriter.vtkXMLPDataWriter_WriteSummaryFileOff_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLPDataWriter_WriteSummaryFileOn_16(HandleRef pThis);

		public virtual void WriteSummaryFileOn()
		{
			vtkXMLPDataWriter.vtkXMLPDataWriter_WriteSummaryFileOn_16(base.GetCppThis());
		}
	}
}
