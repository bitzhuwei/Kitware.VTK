using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkTreeMapToPolyData : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeMapToPolyData";

		public new static readonly string MRClassNameKey;

		static vtkTreeMapToPolyData()
		{
			vtkTreeMapToPolyData.MRClassNameKey = "class vtkTreeMapToPolyData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeMapToPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeMapToPolyData"));
		}

		public vtkTreeMapToPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeMapToPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeMapToPolyData New()
		{
			vtkTreeMapToPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeMapToPolyData.vtkTreeMapToPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeMapToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkTreeMapToPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkTreeMapToPolyData.vtkTreeMapToPolyData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTreeMapToPolyData_FillInputPortInformation_01(HandleRef pThis, int port, HandleRef info);

		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkTreeMapToPolyData.vtkTreeMapToPolyData_FillInputPortInformation_01(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkTreeMapToPolyData_GetAddNormals_02(HandleRef pThis);

		public virtual bool GetAddNormals()
		{
			return vtkTreeMapToPolyData.vtkTreeMapToPolyData_GetAddNormals_02(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkTreeMapToPolyData_GetLevelDeltaZ_03(HandleRef pThis);

		public virtual double GetLevelDeltaZ()
		{
			return vtkTreeMapToPolyData.vtkTreeMapToPolyData_GetLevelDeltaZ_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTreeMapToPolyData_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkTreeMapToPolyData.vtkTreeMapToPolyData_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkTreeMapToPolyData_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkTreeMapToPolyData.vtkTreeMapToPolyData_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeMapToPolyData_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkTreeMapToPolyData NewInstance()
		{
			vtkTreeMapToPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeMapToPolyData.vtkTreeMapToPolyData_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeMapToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkTreeMapToPolyData_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkTreeMapToPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkTreeMapToPolyData vtkTreeMapToPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkTreeMapToPolyData.vtkTreeMapToPolyData_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeMapToPolyData = (vtkTreeMapToPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeMapToPolyData.Register(null);
				}
			}
			return vtkTreeMapToPolyData;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeMapToPolyData_SetAddNormals_09(HandleRef pThis, byte _arg);

		public virtual void SetAddNormals(bool _arg)
		{
			vtkTreeMapToPolyData.vtkTreeMapToPolyData_SetAddNormals_09(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeMapToPolyData_SetLevelArrayName_10(HandleRef pThis, string name);

		public virtual void SetLevelArrayName(string name)
		{
			vtkTreeMapToPolyData.vtkTreeMapToPolyData_SetLevelArrayName_10(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeMapToPolyData_SetLevelDeltaZ_11(HandleRef pThis, double _arg);

		public virtual void SetLevelDeltaZ(double _arg)
		{
			vtkTreeMapToPolyData.vtkTreeMapToPolyData_SetLevelDeltaZ_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkTreeMapToPolyData_SetRectanglesArrayName_12(HandleRef pThis, string name);

		public virtual void SetRectanglesArrayName(string name)
		{
			vtkTreeMapToPolyData.vtkTreeMapToPolyData_SetRectanglesArrayName_12(base.GetCppThis(), name);
		}
	}
}
