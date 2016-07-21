using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkXMLPUnstructuredDataWriter : vtkXMLPDataWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPUnstructuredDataWriter";

		public new static readonly string MRClassNameKey;

		static vtkXMLPUnstructuredDataWriter()
		{
			vtkXMLPUnstructuredDataWriter.MRClassNameKey = "class vtkXMLPUnstructuredDataWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPUnstructuredDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPUnstructuredDataWriter"));
		}

		public vtkXMLPUnstructuredDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPUnstructuredDataWriter_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLPUnstructuredDataWriter.vtkXMLPUnstructuredDataWriter_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPUnstructuredDataWriter_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLPUnstructuredDataWriter.vtkXMLPUnstructuredDataWriter_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPUnstructuredDataWriter_NewInstance_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLPUnstructuredDataWriter NewInstance()
		{
			vtkXMLPUnstructuredDataWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPUnstructuredDataWriter.vtkXMLPUnstructuredDataWriter_NewInstance_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPUnstructuredDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPUnstructuredDataWriter_SafeDownCast_04(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLPUnstructuredDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPUnstructuredDataWriter vtkXMLPUnstructuredDataWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPUnstructuredDataWriter.vtkXMLPUnstructuredDataWriter_SafeDownCast_04((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPUnstructuredDataWriter = (vtkXMLPUnstructuredDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPUnstructuredDataWriter.Register(null);
				}
			}
			return vtkXMLPUnstructuredDataWriter;
		}
	}
}
