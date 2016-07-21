using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkXMLPStructuredDataReader : vtkXMLPDataReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLPStructuredDataReader";

		public new static readonly string MRClassNameKey;

		static vtkXMLPStructuredDataReader()
		{
			vtkXMLPStructuredDataReader.MRClassNameKey = "class vtkXMLPStructuredDataReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLPStructuredDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLPStructuredDataReader"));
		}

		public vtkXMLPStructuredDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLPStructuredDataReader_CopyOutputInformation_01(HandleRef pThis, HandleRef outInfo, int port);

		public override void CopyOutputInformation(vtkInformation outInfo, int port)
		{
			vtkXMLPStructuredDataReader.vtkXMLPStructuredDataReader_CopyOutputInformation_01(base.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis(), port);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPStructuredDataReader_GetExtentTranslator_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkExtentTranslator GetExtentTranslator()
		{
			vtkExtentTranslator vtkExtentTranslator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPStructuredDataReader.vtkXMLPStructuredDataReader_GetExtentTranslator_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern int vtkXMLPStructuredDataReader_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLPStructuredDataReader.vtkXMLPStructuredDataReader_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLPStructuredDataReader_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLPStructuredDataReader.vtkXMLPStructuredDataReader_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPStructuredDataReader_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLPStructuredDataReader NewInstance()
		{
			vtkXMLPStructuredDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPStructuredDataReader.vtkXMLPStructuredDataReader_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLPStructuredDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLPStructuredDataReader_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLPStructuredDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLPStructuredDataReader vtkXMLPStructuredDataReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLPStructuredDataReader.vtkXMLPStructuredDataReader_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLPStructuredDataReader = (vtkXMLPStructuredDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLPStructuredDataReader.Register(null);
				}
			}
			return vtkXMLPStructuredDataReader;
		}
	}
}
