using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkXMLCompositeDataWriter : vtkXMLWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLCompositeDataWriter";

		public new static readonly string MRClassNameKey;

		static vtkXMLCompositeDataWriter()
		{
			vtkXMLCompositeDataWriter.MRClassNameKey = "class vtkXMLCompositeDataWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLCompositeDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLCompositeDataWriter"));
		}

		public vtkXMLCompositeDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLCompositeDataWriter_GetDefaultFileExtension_01(HandleRef pThis);

		public override string GetDefaultFileExtension()
		{
			return Marshal.PtrToStringAnsi(vtkXMLCompositeDataWriter.vtkXMLCompositeDataWriter_GetDefaultFileExtension_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLCompositeDataWriter_GetGhostLevel_02(HandleRef pThis);

		public virtual int GetGhostLevel()
		{
			return vtkXMLCompositeDataWriter.vtkXMLCompositeDataWriter_GetGhostLevel_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLCompositeDataWriter_GetWriteMetaFile_03(HandleRef pThis);

		public virtual int GetWriteMetaFile()
		{
			return vtkXMLCompositeDataWriter.vtkXMLCompositeDataWriter_GetWriteMetaFile_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLCompositeDataWriter_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLCompositeDataWriter.vtkXMLCompositeDataWriter_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLCompositeDataWriter_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLCompositeDataWriter.vtkXMLCompositeDataWriter_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLCompositeDataWriter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLCompositeDataWriter NewInstance()
		{
			vtkXMLCompositeDataWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLCompositeDataWriter.vtkXMLCompositeDataWriter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLCompositeDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLCompositeDataWriter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLCompositeDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLCompositeDataWriter vtkXMLCompositeDataWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLCompositeDataWriter.vtkXMLCompositeDataWriter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLCompositeDataWriter = (vtkXMLCompositeDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLCompositeDataWriter.Register(null);
				}
			}
			return vtkXMLCompositeDataWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLCompositeDataWriter_SetGhostLevel_08(HandleRef pThis, int _arg);

		public virtual void SetGhostLevel(int _arg)
		{
			vtkXMLCompositeDataWriter.vtkXMLCompositeDataWriter_SetGhostLevel_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLCompositeDataWriter_SetWriteMetaFile_09(HandleRef pThis, int flag);

		public virtual void SetWriteMetaFile(int flag)
		{
			vtkXMLCompositeDataWriter.vtkXMLCompositeDataWriter_SetWriteMetaFile_09(base.GetCppThis(), flag);
		}
	}
}
