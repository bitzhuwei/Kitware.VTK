using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkXMLPStructuredDataWriter : vtkXMLPDataWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPStructuredDataWriter";

		public new static readonly string MRClassNameKey;

		static vtkXMLPStructuredDataWriter()
		{
			vtkXMLPStructuredDataWriter.MRClassNameKey = "class vtkXMLPStructuredDataWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPStructuredDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPStructuredDataWriter"));
		}

		public vtkXMLPStructuredDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPStructuredDataWriter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLPStructuredDataWriter.vtkXMLPStructuredDataWriter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPStructuredDataWriter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLPStructuredDataWriter.vtkXMLPStructuredDataWriter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPStructuredDataWriter_NewInstance_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLPStructuredDataWriter NewInstance()
		{
			vtkXMLPStructuredDataWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPStructuredDataWriter.vtkXMLPStructuredDataWriter_NewInstance_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPStructuredDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPStructuredDataWriter_SafeDownCast_04(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLPStructuredDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPStructuredDataWriter vtkXMLPStructuredDataWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPStructuredDataWriter.vtkXMLPStructuredDataWriter_SafeDownCast_04((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPStructuredDataWriter = (vtkXMLPStructuredDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPStructuredDataWriter.Register(null);
				}
			}
			return vtkXMLPStructuredDataWriter;
		}
	}
}
