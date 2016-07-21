using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkXMLUnstructuredDataReader : vtkXMLDataReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLUnstructuredDataReader";

		public new static readonly string MRClassNameKey;

		static vtkXMLUnstructuredDataReader()
		{
			vtkXMLUnstructuredDataReader.MRClassNameKey = "class vtkXMLUnstructuredDataReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLUnstructuredDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLUnstructuredDataReader"));
		}

		public vtkXMLUnstructuredDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLUnstructuredDataReader_CopyOutputInformation_01(HandleRef pThis, HandleRef outInfo, int port);

		public override void CopyOutputInformation(vtkInformation outInfo, int port)
		{
			vtkXMLUnstructuredDataReader.vtkXMLUnstructuredDataReader_CopyOutputInformation_01(base.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis(), port);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern long vtkXMLUnstructuredDataReader_GetNumberOfCells_02(HandleRef pThis);

		public override long GetNumberOfCells()
		{
			return vtkXMLUnstructuredDataReader.vtkXMLUnstructuredDataReader_GetNumberOfCells_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern long vtkXMLUnstructuredDataReader_GetNumberOfPoints_03(HandleRef pThis);

		public override long GetNumberOfPoints()
		{
			return vtkXMLUnstructuredDataReader.vtkXMLUnstructuredDataReader_GetNumberOfPoints_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLUnstructuredDataReader_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLUnstructuredDataReader.vtkXMLUnstructuredDataReader_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLUnstructuredDataReader_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLUnstructuredDataReader.vtkXMLUnstructuredDataReader_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLUnstructuredDataReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLUnstructuredDataReader NewInstance()
		{
			vtkXMLUnstructuredDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLUnstructuredDataReader.vtkXMLUnstructuredDataReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLUnstructuredDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLUnstructuredDataReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLUnstructuredDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLUnstructuredDataReader vtkXMLUnstructuredDataReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLUnstructuredDataReader.vtkXMLUnstructuredDataReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLUnstructuredDataReader = (vtkXMLUnstructuredDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLUnstructuredDataReader.Register(null);
				}
			}
			return vtkXMLUnstructuredDataReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLUnstructuredDataReader_SetupUpdateExtent_08(HandleRef pThis, int piece, int numberOfPieces, int ghostLevel);

		public void SetupUpdateExtent(int piece, int numberOfPieces, int ghostLevel)
		{
			vtkXMLUnstructuredDataReader.vtkXMLUnstructuredDataReader_SetupUpdateExtent_08(base.GetCppThis(), piece, numberOfPieces, ghostLevel);
		}
	}
}
