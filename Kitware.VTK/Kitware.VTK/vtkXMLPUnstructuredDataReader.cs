using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkXMLPUnstructuredDataReader : vtkXMLPDataReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPUnstructuredDataReader";

		public new static readonly string MRClassNameKey;

		static vtkXMLPUnstructuredDataReader()
		{
			vtkXMLPUnstructuredDataReader.MRClassNameKey = "class vtkXMLPUnstructuredDataReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPUnstructuredDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPUnstructuredDataReader"));
		}

		public vtkXMLPUnstructuredDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLPUnstructuredDataReader_CopyOutputInformation_01(HandleRef pThis, HandleRef outInfo, int port);

		public override void CopyOutputInformation(vtkInformation outInfo, int port)
		{
			vtkXMLPUnstructuredDataReader.vtkXMLPUnstructuredDataReader_CopyOutputInformation_01(base.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis(), port);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPUnstructuredDataReader_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLPUnstructuredDataReader.vtkXMLPUnstructuredDataReader_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPUnstructuredDataReader_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLPUnstructuredDataReader.vtkXMLPUnstructuredDataReader_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPUnstructuredDataReader_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLPUnstructuredDataReader NewInstance()
		{
			vtkXMLPUnstructuredDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPUnstructuredDataReader.vtkXMLPUnstructuredDataReader_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPUnstructuredDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPUnstructuredDataReader_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLPUnstructuredDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPUnstructuredDataReader vtkXMLPUnstructuredDataReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPUnstructuredDataReader.vtkXMLPUnstructuredDataReader_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPUnstructuredDataReader = (vtkXMLPUnstructuredDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPUnstructuredDataReader.Register(null);
				}
			}
			return vtkXMLPUnstructuredDataReader;
		}
	}
}
