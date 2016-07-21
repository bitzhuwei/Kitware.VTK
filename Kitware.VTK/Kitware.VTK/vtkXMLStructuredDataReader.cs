using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkXMLStructuredDataReader : vtkXMLDataReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLStructuredDataReader";

		public new static readonly string MRClassNameKey;

		static vtkXMLStructuredDataReader()
		{
			vtkXMLStructuredDataReader.MRClassNameKey = "class vtkXMLStructuredDataReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLStructuredDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLStructuredDataReader"));
		}

		public vtkXMLStructuredDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLStructuredDataReader_CopyOutputInformation_01(HandleRef pThis, HandleRef outInfo, int port);

		public override void CopyOutputInformation(vtkInformation outInfo, int port)
		{
			vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_CopyOutputInformation_01(base.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis(), port);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern long vtkXMLStructuredDataReader_GetNumberOfCells_02(HandleRef pThis);

		public override long GetNumberOfCells()
		{
			return vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_GetNumberOfCells_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern long vtkXMLStructuredDataReader_GetNumberOfPoints_03(HandleRef pThis);

		public override long GetNumberOfPoints()
		{
			return vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_GetNumberOfPoints_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLStructuredDataReader_GetWholeSlices_04(HandleRef pThis);

		public virtual int GetWholeSlices()
		{
			return vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_GetWholeSlices_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLStructuredDataReader_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLStructuredDataReader_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLStructuredDataReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLStructuredDataReader NewInstance()
		{
			vtkXMLStructuredDataReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLStructuredDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLStructuredDataReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLStructuredDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLStructuredDataReader vtkXMLStructuredDataReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLStructuredDataReader = (vtkXMLStructuredDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLStructuredDataReader.Register(null);
				}
			}
			return vtkXMLStructuredDataReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLStructuredDataReader_SetWholeSlices_09(HandleRef pThis, int _arg);

		public virtual void SetWholeSlices(int _arg)
		{
			vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_SetWholeSlices_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLStructuredDataReader_WholeSlicesOff_10(HandleRef pThis);

		public virtual void WholeSlicesOff()
		{
			vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_WholeSlicesOff_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLStructuredDataReader_WholeSlicesOn_11(HandleRef pThis);

		public virtual void WholeSlicesOn()
		{
			vtkXMLStructuredDataReader.vtkXMLStructuredDataReader_WholeSlicesOn_11(base.GetCppThis());
		}
	}
}
