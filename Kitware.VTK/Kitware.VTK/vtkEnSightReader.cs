using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkEnSightReader : vtkGenericEnSightReader
	{
		public enum ElementTypesList
		{
			BAR2 = 1,
			BAR3,
			HEXA20 = 14,
			HEXA8 = 13,
			NFACED = 8,
			NSIDED = 3,
			NUMBER_OF_ELEMENT_TYPES = 17,
			PENTA15 = 16,
			PENTA6 = 15,
			POINT = 0,
			PYRAMID13 = 12,
			PYRAMID5 = 11,
			QUAD4 = 6,
			QUAD8,
			TETRA10 = 10,
			TETRA4 = 9,
			TRIA3 = 4,
			TRIA6
		}

		public enum SectionTypeList
		{
			BLOCK = 1,
			COORDINATES = 0,
			ELEMENT = 2
		}

		public enum VariableTypesList
		{
			COMPLEX_SCALAR_PER_ELEMENT = 10,
			COMPLEX_SCALAR_PER_NODE = 8,
			COMPLEX_VECTOR_PER_ELEMENT = 11,
			COMPLEX_VECTOR_PER_NODE = 9,
			SCALAR_PER_ELEMENT = 3,
			SCALAR_PER_MEASURED_NODE = 6,
			SCALAR_PER_NODE = 0,
			TENSOR_SYMM_PER_ELEMENT = 5,
			TENSOR_SYMM_PER_NODE = 2,
			VECTOR_PER_ELEMENT = 4,
			VECTOR_PER_MEASURED_NODE = 7,
			VECTOR_PER_NODE = 1
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkEnSightReader";

		public new static readonly string MRClassNameKey;

		static vtkEnSightReader()
		{
			vtkEnSightReader.MRClassNameKey = "class vtkEnSightReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEnSightReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEnSightReader"));
		}

		public vtkEnSightReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightReader_GetMatchFileName_01(HandleRef pThis);

		public virtual string GetMatchFileName()
		{
			return Marshal.PtrToStringAnsi(vtkEnSightReader.vtkEnSightReader_GetMatchFileName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightReader_GetMeasuredFileName_02(HandleRef pThis);

		public virtual string GetMeasuredFileName()
		{
			return Marshal.PtrToStringAnsi(vtkEnSightReader.vtkEnSightReader_GetMeasuredFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkEnSightReader_GetParticleCoordinatesByIndex_03(HandleRef pThis);

		public override int GetParticleCoordinatesByIndex()
		{
			return vtkEnSightReader.vtkEnSightReader_GetParticleCoordinatesByIndex_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkEnSightReader_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkEnSightReader.vtkEnSightReader_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkEnSightReader_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkEnSightReader.vtkEnSightReader_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkEnSightReader NewInstance()
		{
			vtkEnSightReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSightReader.vtkEnSightReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSightReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkEnSightReader_ParticleCoordinatesByIndexOff_07(HandleRef pThis);

		public override void ParticleCoordinatesByIndexOff()
		{
			vtkEnSightReader.vtkEnSightReader_ParticleCoordinatesByIndexOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkEnSightReader_ParticleCoordinatesByIndexOn_08(HandleRef pThis);

		public override void ParticleCoordinatesByIndexOn()
		{
			vtkEnSightReader.vtkEnSightReader_ParticleCoordinatesByIndexOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSightReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEnSightReader SafeDownCast(vtkObjectBase o)
		{
			vtkEnSightReader vtkEnSightReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSightReader.vtkEnSightReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEnSightReader = (vtkEnSightReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEnSightReader.Register(null);
				}
			}
			return vtkEnSightReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkEnSightReader_SetParticleCoordinatesByIndex_10(HandleRef pThis, int _arg);

		public override void SetParticleCoordinatesByIndex(int _arg)
		{
			vtkEnSightReader.vtkEnSightReader_SetParticleCoordinatesByIndex_10(base.GetCppThis(), _arg);
		}
	}
}
