using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoTerrainNode : vtkGeoTreeNode
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoTerrainNode";

		public new static readonly string MRClassNameKey;

		static vtkGeoTerrainNode()
		{
			vtkGeoTerrainNode.MRClassNameKey = "class vtkGeoTerrainNode";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoTerrainNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoTerrainNode"));
		}

		public vtkGeoTerrainNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrainNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoTerrainNode New()
		{
			vtkGeoTerrainNode result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTerrainNode.vtkGeoTerrainNode_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoTerrainNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoTerrainNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoTerrainNode.vtkGeoTerrainNode_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_DeepCopy_01(HandleRef pThis, HandleRef src);

		public override void DeepCopy(vtkGeoTreeNode src)
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_DeepCopy_01(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_DeleteData_02(HandleRef pThis);

		public override void DeleteData()
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_DeleteData_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoTerrainNode_GetAltitude_03(HandleRef pThis, double longitude, double latitude);

		public double GetAltitude(double longitude, double latitude)
		{
			return vtkGeoTerrainNode.vtkGeoTerrainNode_GetAltitude_03(base.GetCppThis(), longitude, latitude);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrainNode_GetBoundingSphereCenter_04(HandleRef pThis);

		public virtual double[] GetBoundingSphereCenter()
		{
			IntPtr intPtr = vtkGeoTerrainNode.vtkGeoTerrainNode_GetBoundingSphereCenter_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_GetBoundingSphereCenter_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetBoundingSphereCenter(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_GetBoundingSphereCenter_05(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_GetBoundingSphereCenter_06(HandleRef pThis, IntPtr _arg);

		public virtual void GetBoundingSphereCenter(IntPtr _arg)
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_GetBoundingSphereCenter_06(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoTerrainNode_GetBoundingSphereRadius_07(HandleRef pThis);

		public virtual double GetBoundingSphereRadius()
		{
			return vtkGeoTerrainNode.vtkGeoTerrainNode_GetBoundingSphereRadius_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrainNode_GetChild_08(HandleRef pThis, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGeoTerrainNode GetChild(int idx)
		{
			vtkGeoTerrainNode vtkGeoTerrainNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTerrainNode.vtkGeoTerrainNode_GetChild_08(base.GetCppThis(), idx, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoTerrainNode = (vtkGeoTerrainNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoTerrainNode.Register(null);
				}
			}
			return vtkGeoTerrainNode;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrainNode_GetCornerNormal00_09(HandleRef pThis);

		public virtual double[] GetCornerNormal00()
		{
			IntPtr intPtr = vtkGeoTerrainNode.vtkGeoTerrainNode_GetCornerNormal00_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_GetCornerNormal00_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetCornerNormal00(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_GetCornerNormal00_10(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_GetCornerNormal00_11(HandleRef pThis, IntPtr _arg);

		public virtual void GetCornerNormal00(IntPtr _arg)
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_GetCornerNormal00_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrainNode_GetCornerNormal01_12(HandleRef pThis);

		public virtual double[] GetCornerNormal01()
		{
			IntPtr intPtr = vtkGeoTerrainNode.vtkGeoTerrainNode_GetCornerNormal01_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_GetCornerNormal01_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetCornerNormal01(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_GetCornerNormal01_13(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_GetCornerNormal01_14(HandleRef pThis, IntPtr _arg);

		public virtual void GetCornerNormal01(IntPtr _arg)
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_GetCornerNormal01_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrainNode_GetCornerNormal10_15(HandleRef pThis);

		public virtual double[] GetCornerNormal10()
		{
			IntPtr intPtr = vtkGeoTerrainNode.vtkGeoTerrainNode_GetCornerNormal10_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_GetCornerNormal10_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetCornerNormal10(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_GetCornerNormal10_16(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_GetCornerNormal10_17(HandleRef pThis, IntPtr _arg);

		public virtual void GetCornerNormal10(IntPtr _arg)
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_GetCornerNormal10_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrainNode_GetCornerNormal11_18(HandleRef pThis);

		public virtual double[] GetCornerNormal11()
		{
			IntPtr intPtr = vtkGeoTerrainNode.vtkGeoTerrainNode_GetCornerNormal11_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_GetCornerNormal11_19(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetCornerNormal11(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_GetCornerNormal11_19(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_GetCornerNormal11_20(HandleRef pThis, IntPtr _arg);

		public virtual void GetCornerNormal11(IntPtr _arg)
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_GetCornerNormal11_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern float vtkGeoTerrainNode_GetCoverage_21(HandleRef pThis);

		public virtual float GetCoverage()
		{
			return vtkGeoTerrainNode.vtkGeoTerrainNode_GetCoverage_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoTerrainNode_GetError_22(HandleRef pThis);

		public virtual double GetError()
		{
			return vtkGeoTerrainNode.vtkGeoTerrainNode_GetError_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTerrainNode_GetGraticuleLevel_23(HandleRef pThis);

		public virtual int GetGraticuleLevel()
		{
			return vtkGeoTerrainNode.vtkGeoTerrainNode_GetGraticuleLevel_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrainNode_GetModel_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkPolyData GetModel()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTerrainNode.vtkGeoTerrainNode_GetModel_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrainNode_GetParent_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkGeoTerrainNode GetParent()
		{
			vtkGeoTerrainNode vtkGeoTerrainNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTerrainNode.vtkGeoTerrainNode_GetParent_25(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoTerrainNode = (vtkGeoTerrainNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoTerrainNode.Register(null);
				}
			}
			return vtkGeoTerrainNode;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrainNode_GetProjectionBounds_26(HandleRef pThis);

		public virtual double[] GetProjectionBounds()
		{
			IntPtr intPtr = vtkGeoTerrainNode.vtkGeoTerrainNode_GetProjectionBounds_26(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_GetProjectionBounds_27(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		public virtual void GetProjectionBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_GetProjectionBounds_27(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_GetProjectionBounds_28(HandleRef pThis, IntPtr _arg);

		public virtual void GetProjectionBounds(IntPtr _arg)
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_GetProjectionBounds_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern byte vtkGeoTerrainNode_HasData_29(HandleRef pThis);

		public override bool HasData()
		{
			return vtkGeoTerrainNode.vtkGeoTerrainNode_HasData_29(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTerrainNode_IsA_30(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoTerrainNode.vtkGeoTerrainNode_IsA_30(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTerrainNode_IsTypeOf_31(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoTerrainNode.vtkGeoTerrainNode_IsTypeOf_31(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrainNode_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoTerrainNode NewInstance()
		{
			vtkGeoTerrainNode result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTerrainNode.vtkGeoTerrainNode_NewInstance_33(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoTerrainNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrainNode_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoTerrainNode SafeDownCast(vtkObjectBase o)
		{
			vtkGeoTerrainNode vtkGeoTerrainNode = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTerrainNode.vtkGeoTerrainNode_SafeDownCast_34((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoTerrainNode = (vtkGeoTerrainNode)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoTerrainNode.Register(null);
				}
			}
			return vtkGeoTerrainNode;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_SetCoverage_35(HandleRef pThis, float _arg);

		public virtual void SetCoverage(float _arg)
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_SetCoverage_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_SetError_36(HandleRef pThis, double _arg);

		public virtual void SetError(double _arg)
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_SetError_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_SetGraticuleLevel_37(HandleRef pThis, int _arg);

		public virtual void SetGraticuleLevel(int _arg)
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_SetGraticuleLevel_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_SetModel_38(HandleRef pThis, HandleRef model);

		public void SetModel(vtkPolyData model)
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_SetModel_38(base.GetCppThis(), (model == null) ? default(HandleRef) : model.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_SetProjectionBounds_39(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		public virtual void SetProjectionBounds(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_SetProjectionBounds_39(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_SetProjectionBounds_40(HandleRef pThis, IntPtr _arg);

		public virtual void SetProjectionBounds(IntPtr _arg)
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_SetProjectionBounds_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_ShallowCopy_41(HandleRef pThis, HandleRef src);

		public override void ShallowCopy(vtkGeoTreeNode src)
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_ShallowCopy_41(base.GetCppThis(), (src == null) ? default(HandleRef) : src.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrainNode_UpdateBoundingSphere_42(HandleRef pThis);

		public void UpdateBoundingSphere()
		{
			vtkGeoTerrainNode.vtkGeoTerrainNode_UpdateBoundingSphere_42(base.GetCppThis());
		}
	}
}
