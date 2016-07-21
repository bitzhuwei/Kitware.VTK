using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBSPCuts : vtkDataObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBSPCuts";

		public new static readonly string MRClassNameKey;

		static vtkBSPCuts()
		{
			vtkBSPCuts.MRClassNameKey = "class vtkBSPCuts";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBSPCuts.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBSPCuts"));
		}

		public vtkBSPCuts(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBSPCuts_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBSPCuts New()
		{
			vtkBSPCuts result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBSPCuts.vtkBSPCuts_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBSPCuts() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBSPCuts.vtkBSPCuts_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBSPCuts_CreateCuts_01(HandleRef pThis, IntPtr bounds, int ncuts, IntPtr dim, IntPtr coord, IntPtr lower, IntPtr upper, IntPtr lowerDataCoord, IntPtr upperDataCoord, IntPtr npoints);

		public void CreateCuts(IntPtr bounds, int ncuts, IntPtr dim, IntPtr coord, IntPtr lower, IntPtr upper, IntPtr lowerDataCoord, IntPtr upperDataCoord, IntPtr npoints)
		{
			vtkBSPCuts.vtkBSPCuts_CreateCuts_01(base.GetCppThis(), bounds, ncuts, dim, coord, lower, upper, lowerDataCoord, upperDataCoord, npoints);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBSPCuts_CreateCuts_02(HandleRef pThis, HandleRef kd);

		public void CreateCuts(vtkKdNode kd)
		{
			vtkBSPCuts.vtkBSPCuts_CreateCuts_02(base.GetCppThis(), (kd == null) ? default(HandleRef) : kd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBSPCuts_DeepCopy_03(HandleRef pThis, HandleRef src);

		public override void DeepCopy(vtkDataObject src)
		{
			vtkBSPCuts.vtkBSPCuts_DeepCopy_03(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBSPCuts_Equals_04(HandleRef pThis, HandleRef other, double tolerance);

		public int EqualsWrapper(vtkBSPCuts other, double tolerance)
		{
			return vtkBSPCuts.vtkBSPCuts_Equals_04(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis(), tolerance);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBSPCuts_GetArrays_05(HandleRef pThis, int len, IntPtr dim, IntPtr coord, IntPtr lower, IntPtr upper, IntPtr lowerDataCoord, IntPtr upperDataCoord, IntPtr npoints);

		public int GetArrays(int len, IntPtr dim, IntPtr coord, IntPtr lower, IntPtr upper, IntPtr lowerDataCoord, IntPtr upperDataCoord, IntPtr npoints)
		{
			return vtkBSPCuts.vtkBSPCuts_GetArrays_05(base.GetCppThis(), len, dim, coord, lower, upper, lowerDataCoord, upperDataCoord, npoints);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBSPCuts_GetData_06(HandleRef info, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBSPCuts GetData(vtkInformation info)
		{
			vtkBSPCuts vtkBSPCuts = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBSPCuts.vtkBSPCuts_GetData_06((info == null) ? default(HandleRef) : info.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBSPCuts = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBSPCuts.Register(null);
				}
			}
			return vtkBSPCuts;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBSPCuts_GetData_07(HandleRef v, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBSPCuts GetData(vtkInformationVector v, int i)
		{
			vtkBSPCuts vtkBSPCuts = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBSPCuts.vtkBSPCuts_GetData_07((v == null) ? default(HandleRef) : v.GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBSPCuts = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBSPCuts.Register(null);
				}
			}
			return vtkBSPCuts;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBSPCuts_GetKdNodeTree_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkKdNode GetKdNodeTree()
		{
			vtkKdNode vtkKdNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBSPCuts.vtkBSPCuts_GetKdNodeTree_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkKdNode = (vtkKdNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkKdNode.Register(null);
				}
			}
			return vtkKdNode;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBSPCuts_GetNumberOfCuts_09(HandleRef pThis);

		public virtual int GetNumberOfCuts()
		{
			return vtkBSPCuts.vtkBSPCuts_GetNumberOfCuts_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBSPCuts_Initialize_10(HandleRef pThis);

		public override void Initialize()
		{
			vtkBSPCuts.vtkBSPCuts_Initialize_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBSPCuts_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBSPCuts.vtkBSPCuts_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBSPCuts_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBSPCuts.vtkBSPCuts_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBSPCuts_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBSPCuts NewInstance()
		{
			vtkBSPCuts result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBSPCuts.vtkBSPCuts_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBSPCuts_PrintArrays_15(HandleRef pThis);

		public void PrintArrays()
		{
			vtkBSPCuts.vtkBSPCuts_PrintArrays_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBSPCuts_PrintTree_16(HandleRef pThis);

		public void PrintTree()
		{
			vtkBSPCuts.vtkBSPCuts_PrintTree_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBSPCuts_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBSPCuts SafeDownCast(vtkObjectBase o)
		{
			vtkBSPCuts vtkBSPCuts = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBSPCuts.vtkBSPCuts_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBSPCuts = (vtkBSPCuts)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBSPCuts.Register(null);
				}
			}
			return vtkBSPCuts;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBSPCuts_ShallowCopy_18(HandleRef pThis, HandleRef src);

		public override void ShallowCopy(vtkDataObject src)
		{
			vtkBSPCuts.vtkBSPCuts_ShallowCopy_18(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}
	}
}
