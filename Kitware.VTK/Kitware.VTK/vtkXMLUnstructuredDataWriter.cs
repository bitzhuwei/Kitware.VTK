using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkXMLUnstructuredDataWriter : vtkXMLWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLUnstructuredDataWriter";

		public new static readonly string MRClassNameKey;

		static vtkXMLUnstructuredDataWriter()
		{
			vtkXMLUnstructuredDataWriter.MRClassNameKey = "class vtkXMLUnstructuredDataWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLUnstructuredDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLUnstructuredDataWriter"));
		}

		public vtkXMLUnstructuredDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLUnstructuredDataWriter_GetGhostLevel_01(HandleRef pThis);

		public virtual int GetGhostLevel()
		{
			return vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_GetGhostLevel_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLUnstructuredDataWriter_GetNumberOfPieces_02(HandleRef pThis);

		public virtual int GetNumberOfPieces()
		{
			return vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_GetNumberOfPieces_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLUnstructuredDataWriter_GetWritePiece_03(HandleRef pThis);

		public virtual int GetWritePiece()
		{
			return vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_GetWritePiece_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLUnstructuredDataWriter_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLUnstructuredDataWriter_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLUnstructuredDataWriter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLUnstructuredDataWriter NewInstance()
		{
			vtkXMLUnstructuredDataWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLUnstructuredDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLUnstructuredDataWriter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLUnstructuredDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLUnstructuredDataWriter vtkXMLUnstructuredDataWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLUnstructuredDataWriter = (vtkXMLUnstructuredDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLUnstructuredDataWriter.Register(null);
				}
			}
			return vtkXMLUnstructuredDataWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLUnstructuredDataWriter_SetGhostLevel_08(HandleRef pThis, int _arg);

		public virtual void SetGhostLevel(int _arg)
		{
			vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_SetGhostLevel_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLUnstructuredDataWriter_SetNumberOfPieces_09(HandleRef pThis, int _arg);

		public virtual void SetNumberOfPieces(int _arg)
		{
			vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_SetNumberOfPieces_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLUnstructuredDataWriter_SetWritePiece_10(HandleRef pThis, int _arg);

		public virtual void SetWritePiece(int _arg)
		{
			vtkXMLUnstructuredDataWriter.vtkXMLUnstructuredDataWriter_SetWritePiece_10(base.GetCppThis(), _arg);
		}
	}
}
