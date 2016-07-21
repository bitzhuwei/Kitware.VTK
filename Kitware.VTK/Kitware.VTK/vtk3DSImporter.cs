using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtk3DSImporter : vtkImporter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtk3DSImporter";

		public new static readonly string MRClassNameKey;

		static vtk3DSImporter()
		{
			vtk3DSImporter.MRClassNameKey = "class vtk3DSImporter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtk3DSImporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtk3DSImporter"));
		}

		public vtk3DSImporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtk3DSImporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtk3DSImporter New()
		{
			vtk3DSImporter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtk3DSImporter.vtk3DSImporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtk3DSImporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtk3DSImporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtk3DSImporter.vtk3DSImporter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtk3DSImporter_ComputeNormalsOff_01(HandleRef pThis);

		public virtual void ComputeNormalsOff()
		{
			vtk3DSImporter.vtk3DSImporter_ComputeNormalsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtk3DSImporter_ComputeNormalsOn_02(HandleRef pThis);

		public virtual void ComputeNormalsOn()
		{
			vtk3DSImporter.vtk3DSImporter_ComputeNormalsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtk3DSImporter_GetComputeNormals_03(HandleRef pThis);

		public virtual int GetComputeNormals()
		{
			return vtk3DSImporter.vtk3DSImporter_GetComputeNormals_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtk3DSImporter_GetFileName_04(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtk3DSImporter.vtk3DSImporter_GetFileName_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtk3DSImporter_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtk3DSImporter.vtk3DSImporter_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtk3DSImporter_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtk3DSImporter.vtk3DSImporter_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtk3DSImporter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtk3DSImporter NewInstance()
		{
			vtk3DSImporter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtk3DSImporter.vtk3DSImporter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtk3DSImporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtk3DSImporter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtk3DSImporter SafeDownCast(vtkObjectBase o)
		{
			vtk3DSImporter vtk3DSImporter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtk3DSImporter.vtk3DSImporter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtk3DSImporter = (vtk3DSImporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtk3DSImporter.Register(null);
				}
			}
			return vtk3DSImporter;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtk3DSImporter_SetComputeNormals_10(HandleRef pThis, int _arg);

		public virtual void SetComputeNormals(int _arg)
		{
			vtk3DSImporter.vtk3DSImporter_SetComputeNormals_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtk3DSImporter_SetFileName_11(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtk3DSImporter.vtk3DSImporter_SetFileName_11(base.GetCppThis(), _arg);
		}
	}
}
