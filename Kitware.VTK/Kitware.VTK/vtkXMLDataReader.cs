using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkXMLDataReader : vtkXMLReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLDataReader";

		public new static readonly string MRClassNameKey;

		static vtkXMLDataReader()
		{
			vtkXMLDataReader.MRClassNameKey = "class vtkXMLDataReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLDataReader"));
		}

		public vtkXMLDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLDataReader_CopyOutputInformation_01(HandleRef pThis, HandleRef outInfo, int port);

		public override void CopyOutputInformation(vtkInformation outInfo, int port)
		{
			vtkXMLDataReader.vtkXMLDataReader_CopyOutputInformation_01(base.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis(), port);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern long vtkXMLDataReader_GetNumberOfCells_02(HandleRef pThis);

		public virtual long GetNumberOfCells()
		{
			return vtkXMLDataReader.vtkXMLDataReader_GetNumberOfCells_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern long vtkXMLDataReader_GetNumberOfPoints_03(HandleRef pThis);

		public virtual long GetNumberOfPoints()
		{
			return vtkXMLDataReader.vtkXMLDataReader_GetNumberOfPoints_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLDataReader_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLDataReader.vtkXMLDataReader_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLDataReader_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLDataReader.vtkXMLDataReader_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLDataReader NewInstance()
		{
			vtkXMLDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLDataReader.vtkXMLDataReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLDataReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLDataReader vtkXMLDataReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLDataReader.vtkXMLDataReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLDataReader = (vtkXMLDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLDataReader.Register(null);
				}
			}
			return vtkXMLDataReader;
		}
	}
}
